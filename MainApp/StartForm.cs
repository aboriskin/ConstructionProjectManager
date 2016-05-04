using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApp.Forms;
using MainApp.Helpers;
using MainApp.ViewModels;
using MainApp.ViewModels.Forms;
using Newtonsoft.Json;

namespace MainApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private StartFormViewModel _viewModel;

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.activitiesDataGridView.AutoGenerateColumns = false;
            this.resourcesDataGridView.AutoGenerateColumns = false;

            InitializeNewProject();
        }

        private void InitializeNewProject()
        {
            _viewModel = new StartFormViewModel();
            this.activitiesDataGridView.DataSource = _viewModel.Activities;
            this.resourcesDataGridView.DataSource = _viewModel.Resources;
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            var activity = _viewModel.CreateNewActivity();
            var dialog = new AddEditActivityForm(activity,
                _viewModel.Resources.ToList(),
                isNew: true,
                activityExistsCheck: DoesActivityExist);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                _viewModel.AddActivity(activity);
            }
        }

        private bool DoesActivityExist(int id)
        {
            return _viewModel.Activities.Any(a => a.Id == id);
        }

        private void buttonAddResource_Click(object sender, EventArgs e)
        {
            _viewModel.AddNewResource();
        }

        private void buttonDeleteResources_Click(object sender, EventArgs e)
        {
            foreach (var i in DataGridViewHelper.GetSelectedRowIndexes(resourcesDataGridView))
            {
                var resource = resourcesDataGridView.Rows[i].DataBoundItem as ResourceViewModel;
                _viewModel.RemoveResource(resource);
            }
            activitiesDataGridView.Refresh();
        }

        private void resourcesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("This column only allows numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            e.Cancel = true;
        }

        private void resourcesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            activitiesDataGridView.Refresh();
        }

        private void buttonEditActivity_Click(object sender, EventArgs e)
        {
            var selectedIndexes = DataGridViewHelper.GetSelectedRowIndexes(activitiesDataGridView);

            if (selectedIndexes.Count != 1)
            {
                MessageBox.Show("Please select the only activity to edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var activity = activitiesDataGridView.Rows[selectedIndexes.First()].DataBoundItem as ActivityViewModel;

            var dialog = new AddEditActivityForm(
                activity,
                _viewModel.Resources.ToList(),
                isNew: false,
                activityExistsCheck: DoesActivityExist);
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                activitiesDataGridView.Refresh();
            }
        }

        private void buttonDeleteActivies_Click(object sender, EventArgs e)
        {
            foreach (var i in DataGridViewHelper.GetSelectedRowIndexes(activitiesDataGridView))
            {
                var activity = activitiesDataGridView.Rows[i].DataBoundItem as ActivityViewModel;
                _viewModel.DeleteActivity(activity);
            }
            activitiesDataGridView.Refresh();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeNewProject();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveActivityDialog.ShowDialog();            
        }

        private void saveActivityDialog_FileOk(object sender, CancelEventArgs e)
        {
            var serializedObj = JsonConvert.SerializeObject(_viewModel);
            File.WriteAllText(saveActivityDialog.FileName, serializedObj);
        }
    }
}
