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
                Object _cell = dgvTasks.Rows[_iIndexSelected].Cells[1].Value; //Modified: Pablo Ardèvol, Cells[2] to Cell[1] due to Database Change 
                if (_cell != null)
                {
                    String _strSelectedRowCode = (String)_cell;//_cell.ToString(); // Recover the code
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
        /// DataGridView Configuration
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        private void initGridView()
        {
            fillGrid();

            //Column configuration

            dgvTasks.Columns[0].Visible = false; // We hide id column
            //dgvTasks.Columns["code_team"].Visible = true; // We hide the id_team column
            dgvTasks.Columns[1].HeaderText = "Code"; // We change the column name
            dgvTasks.Columns[2].HeaderText = "Name";
            dgvTasks.Columns[3].HeaderText = "Priority Date";
            dgvTasks.Columns[4].Visible = false; // HeaderText = "Description";
            dgvTasks.Columns[5].Visible = false; // HeaderText = "Localization";
            dgvTasks.Columns[6].HeaderText = "Project";
            dgvTasks.Columns[5].Visible = false; // HeaderText = "Localization";
            dgvTasks.Columns[6].Visible = false;
            dgvTasks.Columns[9].Visible = false; // HeaderText = "Team";
            dgvTasks.Columns[10].Visible = false; // HeaderText = "Task Histories";
            
            // DatagridView Common Configuration 

            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row     
            dgvTasks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTasks.AllowUserToAddRows = false; // Can't add rows
            dgvTasks.AllowUserToDeleteRows = false; // Can't delete rows
            dgvTasks.AllowUserToOrderColumns = false; //Can order columns
            dgvTasks.AllowUserToResizeRows = false; //Can't resize columns
            dgvTasks.Cursor = Cursors.Hand; // Cursor hand type            
            dgvTasks.MultiSelect = false; //Can't multiselect
            dgvTasks.RowTemplate.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false; // We hide the rowheader
            dgvTasks.ClearSelection(); // Clear selection rows

            //Form Common Configurations
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

        /// <summary>
        /// Event triggered every time the view is displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTasks_Activated(object sender, EventArgs e)
        {            
            fillGrid();
            dgvTasks.ClearSelection(); // Clear selection rows.
            dgvTasks.Refresh(); //Refresh the view.            
        }

        private void frmTasks_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        private void fillGrid()
        {
            //The grid with all the tasks will load.
            BindingSource source = new BindingSource();
            source.DataSource = Controller.TaskService.getAllTasks();
            dgvTasks.DataSource = source;
            dgvTasks.Refresh();
            this.Refresh();
        }
    }
}
