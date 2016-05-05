using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModels.Helpers;
using DomainModels.Models;
using MainApp.Helpers;
using Utils.Logging;

namespace MainApp.Forms
{
    public partial class ScheduleForm : Form
    {
        private readonly int _duration;
        private readonly List<Activity> _activities;
        private readonly List<Resource> _resources;

        public ScheduleForm(
            int duration,
            List<Activity> activities,
            List<Resource> resources)
        {
            _duration = duration;
            _activities = activities;
            _resources = resources;
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            labelTotalDays.Text = "Total Days: " + _duration;
            InitializeCommonPropertiesForSchedule();
            InitializeColumns();
            InitializeResourcesRows();
            InitializeActivityRows();
        }

        private void InitializeCommonPropertiesForSchedule()
        {
            dataGridViewSchedule.AutoGenerateColumns = false;
        }

        private void InitializeActivityRows()
        {
            var orderedActivities = _activities.OrderBy(a => a.ActivityDayIndex).ToList();
            foreach (var activity in orderedActivities)
            {
                var rowIndex = dataGridViewSchedule.Rows.Add(activity.Id.ToString());

                var color = activity.Duration > 0 ? Color.Gray : Color.LightGray;

                for (int i = activity.ActivityDayIndex; i <= activity.GetActivityFinalIndex(); i++)
                {
                    dataGridViewSchedule.Rows[rowIndex].Cells[i + 1].Style.BackColor = color;
                }
            }
        }

        private void InitializeResourcesRows()
        {
            var resourceTimelineMap = GetResourceTimelines();
            foreach (var resource in _resources)
            {
                var rowIndex = dataGridViewSchedule.Rows.Add(resource.Name + " | " + resource.MaxAvailableAmountPerDay);
                dataGridViewSchedule.Rows[rowIndex].Frozen = true;
                var consumptionTimeline = resourceTimelineMap[resource.Id].GetTimeline();

                for (int i = 0; i < _duration; i++)
                {
                    var cell = dataGridViewSchedule.Rows[rowIndex].Cells[i + 1];
                    cell.Style.BackColor = GetColor(consumptionTimeline[i], resource.MaxAvailableAmountPerDay);
                    cell.Value = resource.MaxAvailableAmountPerDay - consumptionTimeline[i];
                }
            }
        }

        private void InitializeColumns()
        {
            int fillWeight = Math.Min(50, 65000 / _duration);

            dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Item",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Frozen = true
            });

            for (int i = 1; i <= _duration; i++)
            {
                dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    FillWeight = fillWeight,
                    Width = fillWeight,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    HeaderText = i.ToString()
                });

                if (i % 500 == 0) //workaround not to get ContextSwitchDeadlock: https://earlybites.wordpress.com/2012/04/10/resolution-context-switch-deadlock-was-detected/
                {
                    Application.DoEvents();
                }
            }
        }

        private Dictionary<int, ResourceConsumptionTimeline> GetResourceTimelines()
        {
            var dict = new Dictionary<int, ResourceConsumptionTimeline>();

            foreach (var resource in _resources)
            {
                var timeline = new ResourceConsumptionTimeline(resource);
                timeline.EnsureTimeLineHasEnoughLength(_duration);
                dict.Add(resource.Id, timeline);
            }

            foreach (var activity in _activities)
            {
                if (activity.Duration <= 0)
                {
                    continue;
                }

                var range = new DateRange(activity.ActivityDayIndex, activity.GetActivityFinalIndex());
                foreach (var consumption in activity.ResourceConsumptionsPerDay)
                {
                    dict[consumption.ResourceId].Consume(range, consumption.Amount);
                }
            }
            return dict;
        }

        private Color GetColor(decimal freeResource, decimal maxAmount)
        {
            var rate = freeResource / maxAmount;

            return Color.FromArgb(255, (int)((1 - rate) * 255), (int)(rate * 255), 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            saveCsvDialog.ShowDialog();
        }

        private void saveCsvDialog_FileOk(object sender, CancelEventArgs e)
        {
            var exporter = new CsvExporter();

            try
            {
                exporter.Export(saveCsvDialog.FileName, _activities);
            }
            catch (Exception ex)
            {
                Logger.Log("Csv Export", ex);
                MessageBox.Show("Some error happened during the csv export. Please look at the logs to figure it out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
