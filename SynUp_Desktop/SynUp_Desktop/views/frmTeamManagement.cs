using SynUp_Desktop.controller;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.service;
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
    public partial class frmTeamManagement : Form
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

        public Team AuxTeam;
        public Employee AuxEmployee;

        public frmTeamManagement()
        {
            InitializeComponent();
        }

        #region CRUD
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {

            String _strCode = txtCode.Text;
            String _strName = txtName.Text;

            Boolean createOk = Controller.TeamService.createTeam(_strCode, _strName);

            if (createOk)
            {
                MessageBox.Show("The team was created succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The team wasn't created succesfully!");
            }


        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            Team deleteTeam = Controller.TeamService.deleteTeam(AuxTeam);
            if (deleteTeam != null)
            {
                MessageBox.Show("This team was delete succesfully");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("This team wasn't delete succesfully");
            }
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region VALIDATIONS

        /// <summary>
        /// Event that runs when the text of textbox code changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (this.AuxTeam == null)
            {
                String _strIdCode = txtCode.Text;
                Team _oTeam = Controller.TeamService.readTeam(_strIdCode);

                if (txtCode.Text.Equals("") || _oTeam != null) // We found that the textbox is not empty
                {
                    lblCode.ForeColor = Color.Red;
                    lblCode.Text = "Code*";
                }
                else
                {
                    lblCode.Text = "Code";
                    lblCode.ForeColor = Color.Black;
                }
            }

        }

        #endregion

        /// <summary>
        /// Event that runs when the forms actives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeamManagement_Activated(object sender, EventArgs e)
        {
            if (this.AuxTeam != null)
            {
                // We recover the data of selected team
                this.txtCode.Text = this.AuxTeam.code;
                this.txtName.Text = this.AuxTeam.name;

                this.btnCreateTeam.Enabled = false; // We disable the button to create a team
                this.txtCode.Enabled = false;
                //The grid with all the employees on team will load.
                this.fillDataGrid();
                this.fillComboFilterEmployees();
                this.btnDeleteTeam.Enabled = true;
                this.btnUpdateTeam.Enabled = true;
            }
            else
            {
                this.btnCreateTeam.Enabled = true;
                this.txtCode.Enabled = true;
                this.btnDeleteTeam.Enabled = false;
                this.btnUpdateTeam.Enabled = false;
            }

            //this.btnAddToTeam.Enabled = false;
            //this.btnDeleteToTeam.Enabled = false;
            this.dgvConfiguration();

        }

        /// <summary>
        /// Event that runs when the row changes stat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployeesOnTeam_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
            if (this.dgvEmployeesOnTeam.SelectedRows.Count == 1)
            {
                int _iIndexSelected = this.dgvEmployeesOnTeam.SelectedRows[0].Index;
                Object _cell = dgvEmployeesOnTeam.Rows[_iIndexSelected].Cells[1].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString();
                    this.AuxEmployee = this.Controller.EmployeeService.readEmployee(_strSelectedRowCode);
                }

                this.btnAddToTeam.Enabled = true;
                this.btnDeleteToTeam.Enabled = true;
            }
        }

        /// <summary>
        /// Event that runs when the button back is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.AuxTeam = null;
            this.clearValues();
            this.Close();
        }

        /// <summary>
        /// Event that runs when the button clear is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearValues();

            if (this.btnCreateTeam.Enabled == false)
            {
                this.btnCreateTeam.Enabled = true;
                this.AuxTeam = null;
                if (txtCode.Enabled == false) txtCode.Enabled = true;
                this.btnDeleteTeam.Enabled = false;
                this.btnUpdateTeam.Enabled = false;

            }
        }

        /// <summary>
        /// Method that configurates the datagridview
        /// </summary>
        private void dgvConfiguration()
        {
            // DatagridView Common Configuration 
            this.dgvEmployeesOnTeam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvEmployeesOnTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row            
            this.dgvEmployeesOnTeam.AllowUserToAddRows = false; // Can't add rows
            this.dgvEmployeesOnTeam.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvEmployeesOnTeam.AllowUserToOrderColumns = false; //Can't order columns
            this.dgvEmployeesOnTeam.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvEmployeesOnTeam.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvEmployeesOnTeam.MultiSelect = false; //Can't multiselect
            this.dgvEmployeesOnTeam.RowTemplate.ReadOnly = true;
            this.dgvEmployeesOnTeam.RowHeadersVisible = false; // We hide the rowheader
            this.dgvEmployeesOnTeam.ClearSelection(); // Clear selection rows

            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        /// <summary>
        /// Clear values of textboxs
        /// </summary>
        private void clearValues()
        {
            this.txtCode.Text = "";
            this.txtName.Text = "";
            this.dgvEmployeesOnTeam.DataSource = null;
            this.dgvEmployeesOnTeam.Refresh();

        }

        /// <summary>
        /// Method that configures the datagrid of employees in Team
        /// </summary>
        private void fillDataGrid()
        {
            //TODO: Falta hacer el filtro para mostrar solo los empleados en ese equipo, i
            BindingSource source = new BindingSource();
            source.DataSource = this.Controller.TeamHistoryService.getAllTeamHistoriesByTeam(this.AuxTeam.code);

            this.dgvEmployeesOnTeam.DataSource = source;

            dgvEmployeesOnTeam.Refresh();
        }

        /// <summary>
        /// Method that fill combobox filter of employees
        /// </summary>
        public void fillComboFilterEmployees()
        {
            this.cmbFilterEmployees.Items.Clear();
            this.cmbFilterEmployees.Items.Add("Current");
            this.cmbFilterEmployees.Items.Add("Past");
            this.cmbFilterEmployees.Items.Add("All");

            this.cmbFilterEmployees.SelectedIndex = 0;
        }
        
    }
}

