﻿using SynUp_Desktop.controller;
using SynUp_Desktop.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
        #region CONTROLLER

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

        #endregion

        public frmEmployees()
        {
            InitializeComponent();
        }

        #region FORM EVENTS

        /// <summary>
        /// Event that runs when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            this.dgvConfiguration(); //The grid with all the employees will load. 
            //this.frmEmployees_Activated(sender, e);

            this.fillComboTeams(); //The combo with all the teams will load.

            utilities.Help.walkingControls(this, this.messageHelps_MouseHover, this.messageHelps_MouseLeave);

            this.gbContainer.MouseClick += new MouseEventHandler(this.frmEmployees_MouseClick);
            this.gbHelp.MouseClick += new MouseEventHandler(this.frmEmployees_MouseClick);

            Util.loadMenu(this, this.controller);
        }

        /// <summary>
        /// Event triggered every time the view is displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_Activated(object sender, EventArgs e)
        {
            //The grid with all the employees will load.
            this.dgvConfiguration();
            this.dgvEmployees.ClearSelection(); // Clear selection rows.
            this.dgvEmployees.Refresh(); //Refresh the view.
        }

        /// <summary>
        /// Event that runs when mouse click on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_MouseClick(object sender, MouseEventArgs e)
        {
            this.dgvEmployees.ClearSelection();
            this.dgvEmployees.Refresh();
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
            this.addToTeam();
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

                    //cmbTeamsToAdd.SelectedItem = Controller.TeamService.getTeamOfEmployee(_oSelectedEmployee.nif);
                }
            }
            else
            {
                btnAddToTeam.Enabled = false;
                cmbTeamsToAdd.Enabled = false;
            }

            Util.changeButtonText(this.dgvEmployees, this.btnManagementEmployee);
        }

        #endregion

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
        /// Fills the combobox with the values of the database.
        /// </summary>
        private void fillComboTeams()
        {
            BindingSource source = new BindingSource();
            this.cmbTeamsToAdd.DataSource = this.Controller.TeamService.getAllTeams();
            this.cmbTeamsToAdd.DisplayMember = "Name";
            this.cmbTeamsToAdd.ValueMember = "code";
        }

        /// <summary>
        /// Configurates dataGridView
        /// </summary>
        private void dgvConfiguration()
        {
            this.fillGridView();

            this.cmbTeamsToAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTeamsToAdd.SelectedItem = -1;

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
            //this.dgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;   

            Util.dgvCommonConfiguration(this.dgvEmployees); // Configure the common datagridview

        }

        /// <summary>
        /// Add selected employee to team
        /// </summary>
        private void addToTeam()
        {
            model.pojo.Employee _oSelectedEmployee = null;
            model.pojo.Team _oTeam = null;
            Boolean _blAdd = false;

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

                    model.pojo.TeamHistory _oCurrentTeam = this.Controller.TeamHistoryService.getCurrentTeamHistoryByEmployee(_oSelectedEmployee.nif, _oTeam.code); //We look if the employee already in team

                    if (_oCurrentTeam == null)
                    {
                        if (_oSelectedEmployee != null && _oTeam != null)
                        {
                            _blAdd = this.Controller.TeamService.addToTeam(_oSelectedEmployee.nif, _oTeam.code);
                        }
                        clMessageBox.showMessage(Literal.ADD_EMPLOYEE_TO_TEAM_SUCCESFULL, true, this);
                    }
                    else
                    {
                        clMessageBox.showMessage(Literal.INFO_ON_TEAM, false, this);
                    }
                }
            }
        }

        #region HELP

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {
            this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
        }

        /// <summary>
        /// Event that runs when the mouse leaves labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseLeave(object sender, EventArgs e)
        {
            this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
        }

        /// <summary>
        /// Event that runs when the mouse hover on components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseHover(object sender, EventArgs e)
        {
            int _iIcon = (int)utilities.Help.HelpIcon.INFORMATION;
            String _message = "";

            if (sender.Equals(this.btnManagementEmployee))
            {
                _message = Literal.INFO_BTN_MANAGEMENT;
            }
            else if (sender.Equals(this.lblTeams))
            {
                _message = Literal.INFO_ADD_TEAM;
            }
            else if (sender.Equals(this.dgvEmployees))
            {
                _message = Literal.INFO_DGV;
            }
            else if (sender.Equals(this.btnBack))
            {
                _message = Literal.INFO_BTN_BACK;
            }
            this.HelpMessage(_message, _iIcon);

        }

        /// <summary>
        /// Method that shows message help
        /// </summary>
        private void HelpMessage(String message, int icon)
        {
            this.Height = this.MaximumSize.Height;
            this.pbxIconMessage.Image = utilities.Help.changeIconMessage(icon);
            this.lblHelpMessage.Text = message;
        }

        #endregion

    }
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

/* DELETE: Cristina C. 21052016 Change for generic button
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
*/

/* DELETE: Cristina C. 24052016 Move to event load
/// <summary>
/// Event triggered every time the view is displayed. 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void frmEmployees_Activated(object sender, EventArgs e)
{
//The grid with all the employees will load.
this.fillGridView();
this.dgvEmployees.ClearSelection(); // Clear selection rows.
this.dgvEmployees.Refresh(); //Refresh the view.               

//The combo with all the teams will load.
this.fillComboTeams();

//this.Controller.EmployeeMgtView.AuxEmployee = null;

//We configures the groupbox help
this._blHelp = false;
this.gbHelp.Visible = false;
}*/

/* DELETE: Cristina C 240516. Not used 
    /// <summary>
    /// Event that forms is closed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmEmployees_FormClosing(object sender, FormClosingEventArgs e)
    {
        _blHelp = false;
    }*/

/* DELETE: Cristina C. 27/05/2016 Move to Class help
/// <summary>
/// Method that walkings all controls in form
/// </summary>
/// <param name="pEnabled"></param>
private void walkingControls()
{
foreach (Control _control in this.Controls) //Recorremos los componentes del formulario
{
    if (_control is GroupBox)
    {
        foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
        {
            _inGroupBox.MouseHover += new EventHandler(messageHelps_MouseHover);
            _inGroupBox.MouseLeave += new EventHandler(messageHelps_MouseLeave);
        }
    }
    if (_control is Button)
    {
        _control.MouseHover += new EventHandler(messageHelps_MouseHover);
        _control.MouseLeave += new EventHandler(messageHelps_MouseLeave);
    }
    if (_control is GenericButton)
    {
        _control.MouseHover += new EventHandler(messageHelps_MouseHover);
        _control.MouseLeave += new EventHandler(messageHelps_MouseLeave);
    }
}
}
*/
