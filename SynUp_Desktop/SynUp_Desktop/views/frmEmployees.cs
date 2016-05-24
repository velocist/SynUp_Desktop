using SynUp_Desktop.controller;
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
        /// Event that runs when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            //The grid with all the employees will load.
            this.fillGridView();
            this.dgvConfiguration();
            //this.frmEmployees_Activated(sender, e);

            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;            

            //The combo with all the teams will load.
            this.fillComboTeams();
            
            //We configures the groupbox help
            this._blHelp = false;
            this.gbHelp.Visible = false;
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

                   model.pojo.TeamHistory _oCurrentTeam = this.Controller.TeamHistoryService.getCurrentTeamHistoryByEmployee(_oSelectedEmployee.nif,_oTeam.code); //We look if the employee already in team
                    
                    if (_oCurrentTeam == null)
                    {
                        this.addToTeam(_oSelectedEmployee, _oTeam);
                    }
                    else
                    {
                        clMessageBox.showMessage(clMessageBox.MESSAGE.INTEAM, "employee", this);
                    }

                }
            }
        }

        /*
        /// <summary>
        /// Event that forms is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            _blHelp = false;
        }*/

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

                    /*DELETE: Cristina  C. 240516 No lo utilizamos
                    /*model.pojo.TeamHistory _oCurrentTeamHistory = this.Controller.TeamHistoryService.getCurrentTeamHistoryByEmployee(_strSelectedRowCode);

                    if (_oCurrentTeamHistory != null)
                    {
                        this.cmbTeamsToAdd.SelectedValue = _oCurrentTeamHistory.id_team;
                    }*/
                    /* MessageBox.Show(_oSelectedEmployee.nif);
                    //if(_oSelectedEmployee.TeamHistories)
                    //this.cmbTeamsToAdd.SelectedValue
                    //String _SelectedTeam = this.cmbTeamsToAdd.SelectedValue.ToString();
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
            source.DataSource = this.Controller.EmployeeService.getAllEmployees();
            this.dgvEmployees.DataSource = source;
            this.dgvEmployees.ClearSelection(); // Clear selection rows
            this.dgvEmployees.Refresh();
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
        /// Add selected employee to team
        /// </summary>
        private void addToTeam(model.pojo.Employee pEmployee, model.pojo.Team pTeam)
        {
            //model.pojo.TeamHistory _oTeamHistory = new model.pojo.TeamHistory();
            //model.pojo.TeamHistory _oTeamHistoryControl = null;

            if (pEmployee != null && pTeam != null)
            {
                //_oTeamHistoryControl = null;// this.Controller.TeamHistoryService.readTeamHistory(pEmployee.nif, pTeam.code);

                //if (_oTeamHistoryControl == null)
                //{
                    //USELESS
                    //_oTeamHistory.id_employee = pEmployee.nif;
                    //_oTeamHistory.id_team = pTeam.code;
                    //_oTeamHistory.entranceDay = DateTime.Today;

                    Boolean _blAdd = this.Controller.TeamService.addToTeam(pEmployee.nif, pTeam.code);
                    clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.ADD, "employee", _blAdd, this);
                //}
                //else
                //{
                  //  MessageBox.Show("This employee is already in the team");
                //}
            }
        }

        /// <summary>
        /// Configurates dataGridView
        /// </summary>
        private void dgvConfiguration()
        {
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

            // DatagridView Common Configuration 
            this.dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row     
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmployees.AllowUserToAddRows = false; // Can't add rows
            this.dgvEmployees.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvEmployees.AllowUserToOrderColumns = false; //Can order columns
            this.dgvEmployees.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvEmployees.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvEmployees.MultiSelect = false; //Can't multiselect
            this.dgvEmployees.RowTemplate.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false; // We hide the rowheader           

        }

        #region HELP

        private Boolean _blHelp = false;

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {

            if (_blHelp)
            {
                _blHelp = false;
                this.lblHelpMessage.Text = "";
                this.changeIconMessage(0);
                //this.walkingControls(true);
                this.gbHelp.Visible = false;
            }
            else
            {
                _blHelp = true;
                this.lblHelpMessage.Text = "";
                this.changeIconMessage(0);
                this.walkingControls(false);
                this.gbHelp.Visible = true;
            }
        }

        /// <summary>
        /// Event that runs when the mouse leaves labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseLeave(object sender, EventArgs e)
        {
            if (_blHelp)
            {
                this.changeIconMessage(0);
                this.lblHelpMessage.Text = "";
            }
        }

        /// <summary>
        /// Event that runs when the mouse hover on components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseHover(object sender, EventArgs e)
        {
            if (_blHelp)
            {
                this.changeIconMessage(3);
                if (sender.Equals(this.btnManagementEmployee))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para acceder al formulario de trabajador.";
                }
                else if (sender.Equals(this.lblTeams))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para añadir el trabajador a un equipo.";
                }
                else if (sender.Equals(this.dgvEmployees))
                {
                    this.lblHelpMessage.Text = "Lista de todos los empleados existentes en la base de datos.";
                }
                else if (sender.Equals(this.btnBack))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para volver al menú principal.";
                }
            }
        }

        /// <summary>
        /// Method that walkings all controls in form
        /// </summary>
        /// <param name="pEnabled"></param>
        private void walkingControls(Boolean pEnabled)
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

        /// <summary>
        /// Method that changes the icon message
        /// </summary>
        /// <param name="pIcon"></param>
        private void changeIconMessage(int pIcon)
        {
            String _strFilename = null;
            Bitmap _image = null;

            if (pIcon == 1)
            {
                _strFilename = Application.StartupPath + "\\views\\images\\warning.png";
            }
            else if (pIcon == 2)
            {
                _strFilename = Application.StartupPath + "\\views\\images\\error.png";
            }
            else if (pIcon == 3)
            {
                _strFilename = Application.StartupPath + "\\views\\images\\information.png";

            }
            //Configurates de icon message
            if (_strFilename != null)
            {
                _image = new Bitmap(_strFilename);
            }
            this.pbxIconMessage.Image = _image;

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

//TODO: Voy a probar de limpiar el auxiliar de empleado desde aqui a ver si no falla. FUNCIONA
//this.Controller.EmployeeMgtView.AuxEmployee = null;

//We configures the groupbox help
this._blHelp = false;
this.gbHelp.Visible = false;
}*/
