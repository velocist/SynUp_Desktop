using SynUp_Desktop.controller;
using SynUp_Desktop.model.pojo;
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
    public partial class frmEmployeeSelection : Form
    {
        private Controller controller;
        private Team auxTeam;

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

        public Team AuxTeam
        {
            get
            {
                return auxTeam;
            }

            set
            {
                auxTeam = value;
            }
        }
        
        public frmEmployeeSelection()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Event that runs when the button add to team is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oSelectedEmployee = null;
            model.pojo.Team _oTeam = null;

            if (this.dgvEmployees.SelectedRows.Count >= 1)
            {
                Boolean _blAllCorrect = true;

                DataGridViewSelectedRowCollection _selected = dgvEmployees.SelectedRows;

                foreach (DataGridViewRow _row in _selected)
                {
                    int _iIndexSelected = _row.Index; // Recover the index of selected row
                    Object _cell = this.dgvEmployees.Rows[_iIndexSelected].Cells[0].Value;
                    if (_cell != null)
                    {
                        String _strSelectedRowCode = _cell.ToString(); // Recover the code
                        _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif
                        
                        _oTeam = AuxTeam;
                        model.pojo.TeamHistory _oCurrentTeam = this.Controller.TeamHistoryService.getCurrentTeamHistoryByEmployee(_oSelectedEmployee.nif, _oTeam.code); //We look if the employee already in team

                        if (_oCurrentTeam == null)
                        {
                            if (_oSelectedEmployee != null && _oTeam != null)
                            {
                                Boolean _blAdd = this.Controller.TeamService.addToTeam(_oSelectedEmployee.nif, _oTeam.code);
                            }
                        }
                        else
                        {
                            _blAllCorrect = false;
                        }
                    }
                }

                if (!_blAllCorrect) clMessageBox.showMessage(Literal.INFO_ON_TEAM, false, this);// Error al añadir algun empleado de la lista
                this.Close();

            }
        }

        /// <summary>
        /// Event that runs when the form is load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeSelection_Load(object sender, EventArgs e)
        {
            this.dgvConfiguration();

        }

        /// <summary>
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        private void fillGridView()
        {
            BindingSource source = new BindingSource();
            source.DataSource = this.Controller.EmployeeService.getAllEmployees();
            this.dgvEmployees.DataSource = source;
            this.dgvEmployees.ClearSelection(); // Clear selection rows
            this.dgvEmployees.Refresh();
            this.Refresh();
        }
        
        /// <summary>
        /// Configurates dataGridView
        /// </summary>
        private void dgvConfiguration()
        {
            this.fillGridView();

            // DataGridView Configuration
            //this.dgvEmployees.Columns[0].Visible = false; // We hide id column
            this.dgvEmployees.Columns[0].HeaderText = "NIF";
            this.dgvEmployees.Columns[1].HeaderText = "Name";
            this.dgvEmployees.Columns[2].HeaderText = "Surname";
            this.dgvEmployees.Columns[3].Visible = false;
            this.dgvEmployees.Columns[4].HeaderText = "Email";
            this.dgvEmployees.Columns[5].Visible = false;
            this.dgvEmployees.Columns[6].Visible = false;
            this.dgvEmployees.Columns[7].Visible = false;
            this.dgvEmployees.Columns[8].Visible = false; // TeamsHistory
            this.dgvEmployees.Columns[9].Visible = false; // TaskHistories

            this.dgvEmployees.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            Util.dgvCommonConfiguration(this.dgvEmployees);    

        }

        /// <summary>
        /// Event that runs when the button Cancel is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AuxTeam = null;
        }
    }
}

