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
using DomainModels.Managers;
using GeneticAlgorithm.Managers;
using MainApp.Forms;
using MainApp.Helpers;
using MainApp.ViewModels;
using MainApp.ViewModels.Forms;
using Newtonsoft.Json;
using Utils;
using Utils.Logging;

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

            InitializeProject();
        }

        private void InitializeProject(StartFormViewModel viewModel = null)
        {
            if (viewModel == null)
            {
                _viewModel = new StartFormViewModel();
            }
            else
            {
                _viewModel = viewModel;
            }
            this.activitiesDataGridView.DataSource = _viewModel.Activities;
            this.resourcesDataGridView.DataSource = _viewModel.Resources;
            Refresh();
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
            MessageBox.Show("This column allows only numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            InitializeProject();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GetFileName()))
            {
                SaveAs();
            }
            else
            {
                SaveData();
            }
        }

        private void SaveAs()
        {
            saveActivityDialog.ShowDialog();
        }

        private void saveActivityDialog_FileOk(object sender, CancelEventArgs e)
        {
            SetFileName(saveActivityDialog.FileName);
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                var serializedObj = JsonConvert.SerializeObject(_viewModel);
                File.WriteAllText(GetFileName(), serializedObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error happened while saving the file. You can see the log file for the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Log("Save Data error", ex);
            }
        }

        private string _fileName = null;
        private void SetFileName(string fileName)
        {
            _fileName = fileName;
        }

        private String GetFileName()
        {
            return _fileName;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                saveToolStripMenuItem_Click(saveToolStripMenuItem, new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }        

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openActivityDialog.ShowDialog();
        }

        private void openActivityDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var content = File.ReadAllText(openActivityDialog.FileName);
                var viewModel = JsonConvert.DeserializeObject<StartFormViewModel>(content);
                viewModel.SetInternalLinks();
                InitializeProject(viewModel);

                SetFileName(openActivityDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error happened while openning the file. Try it again. You can see the log file for the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Log("Load Data error", ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void geneticAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Genetic_algorithm");
        }

        private void originalArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pdfs.semanticscholar.org/4192/087466abe61298acedc053bb16bd735a3a02.pdf");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBoxForm();
            about.ShowDialog();
        }

        private void buttonRunAlgorithm_Click(object sender, EventArgs e)
        {
            string error = ValidateAlgorithmParams();
            if (String.IsNullOrEmpty(error))
            {
                error = _viewModel.Validate();
            }
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var domainActivities = _viewModel.GetDomainActivities();
            var domainResources = _viewModel.GetDomainResources();
            var solver = new Solver(domainActivities, domainResources);

            var worker = new BackgroundWorker();
            BestChromosomesKeeper<int> bestResultsKeeper = null;
            worker.DoWork += (item, args) =>
            {
                bestResultsKeeper = solver.Run(int.Parse(textBoxPopulationSize.Text),
                int.Parse(textBoxMaxIterations.Text),
                double.Parse(textBoxCrossoverProbability.Text),
                double.Parse(textBoxMutationProbability.Text));
            };

            worker.RunWorkerCompleted += (item, args) =>
            {
                pictureBoxLoading.Visible = false;
                labelStatus.Text = "The solution is found. Preparing the form ...";
                var duration = solver.CalculateSchedule(bestResultsKeeper.GetBestResults()[0].Chromosome);
                var form = new ScheduleForm((int)duration, domainActivities, domainResources);
                form.ShowDialog();
                labelStatus.Text = @"Enter the data and click ""Run""";
            };

            pictureBoxLoading.Visible = true;
            labelStatus.Text = "Processing ...";
            worker.RunWorkerAsync();            
        }

        private string ValidateAlgorithmParams()
        {
            if (!FormatHelper.IsInteger(textBoxPopulationSize.Text))
            {
                return "Population size must be a number";
            }

            if (!FormatHelper.IsInteger(textBoxMaxIterations.Text))
            {
                return "Max Iterations must be a number";
            }

            if (!FormatHelper.ValidateProbabity(textBoxCrossoverProbability.Text))
            {
                return "Please enter the valid crossover probability";
            }

            if (!FormatHelper.ValidateProbabity(textBoxMutationProbability.Text))
            {
                return "Please enter the valid mutation probability";
            }

            return null;
        }
    }
}
