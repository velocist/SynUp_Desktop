using SynUp_Desktop.controller;
using SynUp_Desktop.utilities;
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
    /// <summary>
    /// Form of list employees
    /// </summary>
    /// <Author>Cristina Caballero</Author>
    public partial class frmEmployees : Form
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

        public frmEmployees()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that runs when the button is clicked to manage employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagementEmployee_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oSelectedEmployee = null;
            if (dgvEmployees.SelectedRows.Count == 1)//If the row selected

            {
                int _iIndexSelected = dgvEmployees.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = dgvEmployees.Rows[_iIndexSelected].Cells[0].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif
                    this.Controller.EmployeeMgtView.AuxEmployee = _oSelectedEmployee; // We assign the employee to form employee management
                }
            }


            this.Controller.EmployeeMgtView.ShowDialog();
        }

        /// <summary>
        /// Event that runs when the button is clicked to add team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oSelectedEmployee = null;
            model.pojo.Team _oTeam = null;

            if (this.dgvEmployees.SelectedRows.Count == 1)//If the row selected
            {
                int _iIndexSelected = this.dgvEmployees.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = this.dgvEmployees.Rows[_iIndexSelected].Cells[0].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif

                    String _SelectedTeam = this.cmbTeamsToAdd.SelectedValue.ToString();
                    _oTeam = this.Controller.TeamService.readTeam(_SelectedTeam);

                    this.addToTeam(_oSelectedEmployee, _oTeam);
                }
            }
        }

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Controller.MainView.Show();
        }

        /// <summary>
        /// Event triggered every time the view is displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Activated");
            this.fillGridView(); //The grid with all the employees will load.
            this.dgvEmployees.ClearSelection(); // Clear selection rows.
            this.dgvEmployees.Refresh(); //Refresh the view.               

            // DataGridView Configuration
            //this.dgvEmployees.Columns[0].Visible = false; // We hide id column
            this.dgvEmployees.Columns[8].Visible = false; // TeamsHistory
            this.dgvEmployees.Columns[9].Visible = false; // TaskHistories

            this.dgvEmployees.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            //this.dgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader; 

            //The combo with all the teams will load.
            this.fillComboTeams();
        }

        /// <summary>
        /// Event that runs when the row state change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployees_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                btnAddToTeam.Enabled = true;
                cmbTeamsToAdd.Enabled = true;

                int _iIndexSelected = dgvEmployees.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = dgvEmployees.Rows[_iIndexSelected].Cells[0].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    model.pojo.Employee _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif

                    //MessageBox.Show(_oSelectedEmployee.nif);

                    //if(_oSelectedEmployee.TeamHistories)

                    //this.cmbTeamsToAdd.SelectedValue

                    /*String _SelectedTeam = this.cmbTeamsToAdd.SelectedValue.ToString();
                    _oTeam = this.Controller.TeamService.readTeam(_SelectedTeam);

                    this.addToTeam(_oSelectedEmployee, _oTeam);*/
                }

            }
            else
            {
                btnAddToTeam.Enabled = false;
                cmbTeamsToAdd.Enabled = false;
            }
        }

        /// <summary>
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        private void fillGridView()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Controller.EmployeeService.getAllEmployees();
            this.dgvEmployees.DataSource = source;
            dgvEmployees.Refresh();
        }

        /// <summary>
        /// Fills the combobox with the values of the database.
        /// </summary>
        private void fillComboTeams()
        {
            BindingSource source = new BindingSource();
            this.cmbTeamsToAdd.DataSource = Controller.TeamService.getAllTeams();
            this.cmbTeamsToAdd.DisplayMember = "Name";
            this.cmbTeamsToAdd.ValueMember = "code";

        }

        /// <summary>
        /// Add selected employee to team
        /// </summary>
        private void addToTeam(model.pojo.Employee pEmployee, model.pojo.Team pTeam)
        {
            //model.pojo.TeamHistory _oTeamHistory = new model.pojo.TeamHistory();
            model.pojo.TeamHistory _oTeamHistoryControl = null;

            if (pEmployee != null && pTeam != null)
            {
                _oTeamHistoryControl = null;// this.Controller.TeamHistoryService.readTeamHistory(pEmployee.nif, pTeam.code);

                if (_oTeamHistoryControl == null)
                {
                    //USELESS
                    //_oTeamHistory.id_employee = pEmployee.nif;
                    //_oTeamHistory.id_team = pTeam.code;
                    //_oTeamHistory.entranceDay = DateTime.Today;

                    Boolean _blAdd = this.Controller.TeamService.addToTeam(pEmployee.nif, pTeam.code);
                    clMessageBox.showMessage(clMessageBox.ACTIONTYPE.ADD, "employee", _blAdd, this);
                }
                else
                {
                    MessageBox.Show("This employee is already in the team");
                }
            }
        }

        /// <summary>
        /// Configurates dataGridView
        /// </summary>
        private void dgvConfiguration()
        {
            // DatagridView Common Configuration 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row     
            dgvEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.AllowUserToAddRows = false; // Can't add rows
            dgvEmployees.AllowUserToDeleteRows = false; // Can't delete rows
            dgvEmployees.AllowUserToOrderColumns = false; //Can order columns
            dgvEmployees.AllowUserToResizeRows = false; //Can't resize columns
            dgvEmployees.Cursor = Cursors.Hand; // Cursor hand type            
            dgvEmployees.MultiSelect = false; //Can't multiselect
            dgvEmployees.RowTemplate.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false; // We hide the rowheader
            dgvEmployees.ClearSelection(); // Clear selection rows

            //Form Common Configurations
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            this.dgvConfiguration();
            this.frmEmployees_Activated(sender, e);
        }

        /* DELETE: Cambio evento por RowsStateChange. 17/05/2016-1131
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                btnAddToTeam.Enabled = true;
                cmbTeamsToAdd.Enabled = true;
            }
            else
            {
                btnAddToTeam.Enabled = false;
                cmbTeamsToAdd.Enabled = false;
            }

        }
        */
    }
}
