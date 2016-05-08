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
using SynUp_Desktop.service;
using SynUp_Desktop.model.pojo;

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
            model.pojo.Task _oSelectedTask = null;
            if (dgvTasks.SelectedRows.Count == 1)//If the row selected

            {
                int _iIndexSelected = dgvTasks.SelectedRows[0].Index;
                String _strSelectedRowCode = dgvTasks.Rows[_iIndexSelected].Cells[2].Value.ToString(); // Recover the code
                _oSelectedTask = TaskService.readTask(_strSelectedRowCode); // We look for the task code

                this.Controller.TaskMgtView1.AuxTask = _oSelectedTask; // We assign the task to form task management
            }

            //this.Hide();
            this.Controller.TaskMgtView1.ShowDialog();
            //this.Show();
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
            /// He ocultado las dos primeras columnas. Lo he hecho de dos maneras para que veas como se puede hacer.

            BindingSource source = new BindingSource();
            source.DataSource = Controller.Service.getAllTasks();

            dgvTasks.DataSource = source;            

            dgvTasks.Columns[0].Visible = false; // We hide id column
            dgvTasks.Columns["id_team"].Visible = false; // We hide the id_team column

            dgvTasks.Columns[2].HeaderText = "Code"; // We change the column name
            dgvTasks.Columns[3].HeaderText = "Name";
            dgvTasks.Columns[4].HeaderText = "Priority Date";
            dgvTasks.Columns[5].HeaderText = "Description";
            dgvTasks.Columns[6].HeaderText = "Localization";
            dgvTasks.Columns[7].HeaderText = "Project";
            dgvTasks.Columns[8].HeaderText = "Task Histories";
            dgvTasks.Columns[9].HeaderText = "Team";

            dgvTasks.AutoResizeColumns();
            dgvTasks.RowHeadersVisible = false;

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
