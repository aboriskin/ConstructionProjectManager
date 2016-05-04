using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApp.Helpers;
using MainApp.ViewModels;
using Utils;

namespace MainApp.Forms
{
    public partial class AddEditActivityForm : Form
    {
        private const int NoSelectedResourceId = -1;
        private const string PreActivitiesWatermark = "Pre-activity IDs delimited by comma";

        public AddEditActivityForm()
        {
            InitializeComponent();
        }

        public AddEditActivityForm(
            ActivityViewModel activity,
            List<ResourceViewModel> resources,
            bool isNew,
            Func<int, bool> activityExistsCheck)
            : this()
        {
            _activity = activity;
            _resources = resources;
            _isNew = isNew;
            _activityExistsCheck = activityExistsCheck;       

            if (isNew)
            {
                Text = "Add Activity";                
            }
            else
            {
                Text = "Edit Activity";
                textBoxId.Enabled = false;
            }

            InitializeControls();
        }

        private readonly ActivityViewModel _activity;
        private readonly bool _isNew;
        private readonly Func<int, bool> _activityExistsCheck; 

        private readonly List<ResourceViewModel> _resources;
        private BindingList<ActivityResourceViewModel> _activityResources;

        private void InitializeControls()
        {
            textBoxId.Text = _activity.Id.ToString();            
            textBoxName.Text = _activity.Name;
            if (!_isNew)
            {
                textBoxDuration.Text = _activity.Duration.ToString();
            }

            if (String.IsNullOrEmpty(_activity.PreActivitiesDescription))
            {
                textBoxPreActivities.Text = PreActivitiesWatermark;
            }
            else
            {
                textBoxPreActivities.Text = _activity.PreActivitiesDescription;
            }

            var activities = _activity.Resources.Select(r => r.Clone()).ToList();
            _activityResources = new BindingList<ActivityResourceViewModel>(activities);

            if (_activity.To != null || _activity.From != null)
            {
                if (_activity.IsStartLimited)
                {
                    radioButtonStart.Checked = true;
                    InitializeDatePickers(dateTimePickerStartFrom, dateTimePickerStartTo);
                }
                else
                {
                    radioButtonFinish.Checked = true;
                    InitializeDatePickers(dateTimePickerFinishFrom, dateTimePickerFinishTo);
                }
            }
        }

        private void InitializeDatePickers(DateTimePicker from, DateTimePicker to)
        {
            from.Enabled = to.Enabled = true;
            from.Checked = _activity.From != null;
            if (from.Checked)
            {
                from.Value = _activity.From.Value;
            }

            to.Checked = _activity.To != null;
            if (to.Checked)
            {
                to.Value = _activity.To.Value;
            }
        }

        private void AddEditActivityForm_Load(object sender, EventArgs e)
        {
            var resourcesColumn = (dataGridViewResources.Columns[0] as DataGridViewComboBoxColumn);
            resourcesColumn.DataSource = GetResourcesColumnDataSource();
            resourcesColumn.DisplayMember = "ResourceName";
            resourcesColumn.ValueMember = "Id";
            resourcesColumn.DataPropertyName = "ResourceId";

            dataGridViewResources.DataSource = _activityResources;
        }

        private List<ResourceViewModel> GetResourcesColumnDataSource()
        {
            var result = _resources.ToList();
            result.Insert(0, new ResourceViewModel() { Id = NoSelectedResourceId, ResourceName = "Not selected" });
            return result;
        }

        private void buttonAddResource_Click(object sender, EventArgs e)
        {
            _activityResources.Add(new ActivityResourceViewModel { ResourceId = NoSelectedResourceId });
        }

        private void radioButtonTimeConstraint_Click(object sender, EventArgs e)
        {
            if (radioButtonStart.Checked)
            {
                dateTimePickerStartFrom.Enabled = dateTimePickerStartTo.Enabled = true;
                dateTimePickerFinishFrom.Enabled = dateTimePickerFinishTo.Enabled = false;
            }

            if (radioButtonFinish.Checked)
            {
                dateTimePickerStartFrom.Enabled = dateTimePickerStartTo.Enabled = false;
                dateTimePickerFinishFrom.Enabled = dateTimePickerFinishTo.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var errorMessage = ValidateActivity();

            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _activity.Id = int.Parse(textBoxId.Text);
            _activity.Duration = int.Parse(textBoxDuration.Text);
            _activity.Name = textBoxName.Text;
            _activity.PreActivityIds = ParsePreactivityList();

            _activity.Resources = _activityResources.Where(r => r.ResourceId != NoSelectedResourceId).ToList();

            _activity.IsStartLimited = radioButtonStart.Checked;
            if (radioButtonStart.Checked)
            {
                _activity.From = dateTimePickerStartFrom.Checked ? dateTimePickerStartFrom.Value.Date : (DateTime?)null;
                _activity.To = dateTimePickerStartTo.Checked ? dateTimePickerStartTo.Value.Date : (DateTime?)null;
            }
            else
            {
                _activity.From = dateTimePickerFinishFrom.Checked ? dateTimePickerFinishFrom.Value.Date : (DateTime?)null;
                _activity.To = dateTimePickerFinishTo.Checked ? dateTimePickerFinishTo.Value.Date : (DateTime?)null;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private List<int> ParsePreactivityList()
        {
            if (textBoxPreActivities.Text.Equals(PreActivitiesWatermark))
            {
                return new List<int>();
            }

            var str = textBoxPreActivities.Text.Replace(" ", "");
            return
                str.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => int.Parse(item))
                    .ToList();
        }

        public string ValidateResources()
        {
            var filteredResources = _activityResources.Where(r => r.ResourceId != NoSelectedResourceId).ToList();

            if (filteredResources.Count != filteredResources.Select(r => r.ResourceId).Distinct().Count())
            {
                return "Some resources are duplicated.";
            }

            if (filteredResources.Any(r => r.Amount <= 0))
            {
                return "Resource consumption can be only positive.";
            }

            return null;
        }

        private string ValidateActivity()
        {
            if (!FormatHelper.IsInteger(textBoxId.Text))
            {
                return "Id field must be a numeric";
            }
            var activityId = int.Parse(textBoxId.Text);

            if (_isNew && _activityExistsCheck(activityId))
            {
                return "Activity with the same ID already exists";
            }

            if (!FormatHelper.IsInteger(textBoxDuration.Text))
            {
                return "Duration field must be a numeric";
            }

            if (!textBoxPreActivities.Text.Equals(PreActivitiesWatermark))
            {
                var preActivitiesRegex = new Regex(@"^[,\d ]*$");
                if (!preActivitiesRegex.IsMatch(textBoxPreActivities.Text))
                {
                    return "Please, make sure the preactivity list is array of numbers delimited by comma";
                }
            }

            var preactivityIds = ParsePreactivityList();
            if (preactivityIds.Contains(activityId))
            {
                return "The activity cannot depend on itself";
            }
            
            var errorMessage = ValidateResources();

            if (!String.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            if (radioButtonStart.Checked && dateTimePickerStartFrom.Checked && dateTimePickerStartTo.Checked)
            {
                if (dateTimePickerStartFrom.Value.Date > dateTimePickerStartTo.Value.Date)
                {
                    return "Time constraint interval is not valid.";
                }
            }

            if (radioButtonFinish.Checked && dateTimePickerFinishFrom.Checked && dateTimePickerFinishTo.Checked)
            {
                if (dateTimePickerFinishFrom.Value.Date > dateTimePickerFinishTo.Value.Date)
                {
                    return "Time constraint interval is not valid.";
                }
            }

            return null;
        }

        private void buttonDeleteResources_Click(object sender, EventArgs e)
        {            
            foreach (var i in DataGridViewHelper.GetSelectedRowIndexes(dataGridViewResources))
            {
                var resource = dataGridViewResources.Rows[i].DataBoundItem as ActivityResourceViewModel;
                _activityResources.Remove(resource);
            }
        }

        private void textBoxPreActivities_Enter(object sender, EventArgs e)
        {
            if (textBoxPreActivities.Text.Equals(PreActivitiesWatermark))
            {
                textBoxPreActivities.Clear();
            }
        }

        private void textBoxPreActivities_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPreActivities.Text))
            {
                textBoxPreActivities.Text = PreActivitiesWatermark;
            }
        }
    }
}
