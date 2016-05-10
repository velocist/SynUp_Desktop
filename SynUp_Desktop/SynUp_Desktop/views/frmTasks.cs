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
                int _iIndexSelected = dgvTasks.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = dgvTasks.Rows[_iIndexSelected].Cells[2].Value;
                if(_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedTask = Controller.TaskService.readTask(_strSelectedRowCode); // We look for the task code
                    this.Controller.TaskMgtView.AuxTask = _oSelectedTask; // We assign the task to form task management
                }                
            }

            //this.Hide();
            this.Controller.TaskMgtView.ShowDialog();
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

            BindingSource source = new BindingSource();
            source.DataSource = Controller.TaskService.getAllTasks();

            dgvTasks.DataSource = source;

            // DataGridView Configuration

            dgvTasks.Columns[0].Visible = false; // We hide id column
            //dgvTasks.Columns["code_team"].Visible = true; // We hide the id_team column

            dgvTasks.Columns[2].HeaderText = "Code"; // We change the column name
            dgvTasks.Columns[3].HeaderText = "Name";
            dgvTasks.Columns[4].HeaderText = "Priority Date";
            dgvTasks.Columns[5].Visible = false; // HeaderText = "Description";
            dgvTasks.Columns[6].Visible = false; // HeaderText = "Localization";
            dgvTasks.Columns[7].HeaderText = "Project";
            //dgvTasks.Columns[8].Visible = false; // HeaderText = "Task Histories";
            //dgvTasks.Columns[9].Visible = false;// = "Team";

            dgvTasks.AutoResizeColumns();
            dgvTasks.RowHeadersVisible = false; // We hide the rowheader
            dgvTasks.ClearSelection(); // Cleer selection rows

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

            // DatagridView Common Configuration 
            this.dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row            
            this.dgvTasks.AllowUserToAddRows = false; // Can't add rows
            this.dgvTasks.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvTasks.AllowUserToOrderColumns = false; //Can't order columns
            this.dgvTasks.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvTasks.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvTasks.MultiSelect = false; //Can't multiselect
            this.dgvTasks.RowTemplate.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false; // We hide the rowheader
            this.dgvTasks.ClearSelection(); // Clear selection rows

            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
