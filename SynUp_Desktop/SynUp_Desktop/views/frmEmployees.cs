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
                Object _cell = dgvEmployees.Rows[_iIndexSelected].Cells[1].Value;
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
            //TODO Mostrar dialogo con combo para elegir equipo, o Mostrar la lista de equipos
            model.pojo.Employee _oSelectedEmployee = null;
            if (dgvEmployees.SelectedRows.Count == 1)//If the row selected
            {
                int _iIndexSelected = dgvEmployees.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = dgvEmployees.Rows[_iIndexSelected].Cells[1].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif

                    String _SelectedTeam = this.cmbTeamsToAdd.SelectedValue.ToString();
                    model.pojo.Team _oTeam = this.Controller.TeamService.readTeam(_SelectedTeam);

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

            //The grid with all the employees will load.
            this.fillGridView();

            //The combo with all the teams will load.
            this.fillComboTeams();

            // DataGridView Configuration
            this.dgvEmployees.Columns[0].Visible = false; // We hide id column
            //this.dgvEmployees.Columns[7].Visible = false; // TeamsHistory
            //this.dgvEmployees.Columns[8].Visible = false; // TaskHistories

            this.dgvEmployees.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            // DatagridView Common Configuration 
            this.dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row            
            this.dgvEmployees.AllowUserToAddRows = false; // Can't add rows
            this.dgvEmployees.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvEmployees.AllowUserToOrderColumns = false; //Can't order columns
            this.dgvEmployees.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvEmployees.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvEmployees.MultiSelect = false; //Can't multiselect
            this.dgvEmployees.RowTemplate.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false; // We hide the rowheader
            this.dgvEmployees.ClearSelection(); // Clear selection rows

            //Form Common Configurations            
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

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
            this.cmbTeamsToAdd.ValueMember = "Code";
        }

        /// <summary>
        /// Add selected employee to team
        /// </summary>
        private void addToTeam(model.pojo.Employee pEmployee, model.pojo.Team pTeam)
        {
            model.pojo.TeamHistory _oTeamHistory = new model.pojo.TeamHistory();

            _oTeamHistory.id_employee = pEmployee.id;
            _oTeamHistory.id_team = pTeam.id;
            // _oTeamHistory.Employee = pEmployee;
            //_oTeamHistory.Team = pTeam;
            _oTeamHistory.entranceDay = DateTime.Today;
            _oTeamHistory.exitDate = DateTime.Today;

            Boolean _blAddOk = this.Controller.TeamService.addToTeam(pEmployee, pTeam);

            if (_blAddOk)
            {
                MessageBox.Show("The employee has been added to team");
            } else
            {
                MessageBox.Show("The employee hasn't been added to team");
            }

        }

    }
}
