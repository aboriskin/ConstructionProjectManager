using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApp.Forms;
using MainApp.Helpers;
using MainApp.ViewModels;
using MainApp.ViewModels.Forms;

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
            _viewModel = new StartFormViewModel();

            this.activitiesDataGridView.DataSource = _viewModel.Activities;
            this.resourcesDataGridView.DataSource = _viewModel.Resources;
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            var addActivityForm = new AddEditActivityForm();
            addActivityForm.ShowDialog();
        }

        private void buttonAddResource_Click(object sender, EventArgs e)
        {
            _viewModel.AddNewResource();
        }

        private void buttonDeleteResources_Click(object sender, EventArgs e)
        {
            foreach(var i in DataGridViewHelper.GetSelectedRowIndexes(resourcesDataGridView))
            {
                var resource = resourcesDataGridView.Rows[i].DataBoundItem as ResourceViewModel;
                _viewModel.RemoveResource(resource);
            }
        }

        private void resourcesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("This column only allows numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            e.Cancel = true;
        }
    }
}
