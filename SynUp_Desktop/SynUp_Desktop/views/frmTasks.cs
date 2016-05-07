using SynUp_Desktop.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.views
{
    public partial class frmTasks : Form
    {
        private Controller controller;

        public Controller Controller
        {
            get
            {
                return controller;
            }

            set
            {
                controller = value;
            }
        }
        public frmTasks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the management view window of the tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagementTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Controller.TaskMgtView1.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Event that runs when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        private void fillGridView()
        {
            ///Note: Revisar si se puedes escoger los nombres de las columnas y las que aparecen al hacer el binding.

            BindingSource source = new BindingSource();
            source.DataSource = Controller.Service.getAllTasks();

            dgvTasks.DataSource = source;
            dgvTasks.AutoResizeColumns();
            //dgvTasks.RowHeadersVisible = false;
            dgvTasks.Refresh();
        }

        /// <summary>
        /// Event triggered every time the view is displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTasks_Activated(object sender, EventArgs e)
        {
            //The grid with all the tasks will load.
            fillGridView();
        }
    }
}
