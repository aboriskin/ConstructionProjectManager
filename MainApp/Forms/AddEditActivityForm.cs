using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApp.ViewModels;

namespace MainApp.Forms
{
    public partial class AddEditActivityForm : Form
    {
        public AddEditActivityForm()
        {
            InitializeComponent();

            Text = "Add Activity";
        }

        public AddEditActivityForm(ActivityViewModel activity)
            : this()
        {
            _activity = activity;

            Text = "Edit Activity";
        }

        private readonly ActivityViewModel _activity;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
