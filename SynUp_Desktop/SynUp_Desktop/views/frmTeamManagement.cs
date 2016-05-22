using SynUp_Desktop.controller;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SynUp_Desktop.views
{
    /// <summary>
    /// Form of management team
    /// </summary>
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

        /// <summary>
        /// Event that runs when the button create is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {

            String _strCode = txtCode.Text;
            String _strName = txtName.Text;

            Boolean _blCreate = Controller.TeamService.createTeam(_strCode, _strName);
            clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.CREATE, "team", _blCreate, this);

        }

        /// <summary>
        /// Event that runs when the button delete is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            Boolean _blDelete = false;
            Team deleteTeam = Controller.TeamService.deleteTeam(AuxTeam);
            if (deleteTeam != null)
            {
                _blDelete = true;
            }
            else
            {
                _blDelete = false;
            }
            clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.DELETE, "team", _blDelete, this);
        }

        /// <summary>
        /// Event that runs when the button update is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            String _strName = txtName.Text;
            String _strCode = txtCode.Text;
            Boolean _blUpdate = this.Controller.TeamService.updateTeam(_strCode, _strName);
            clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.UPDATE, "team", _blUpdate, this);
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
                    //lblCode.Text = "Code*";
                }
                else
                {
                    //lblCode.Text = "Code";
                    lblCode.ForeColor = Color.Black;
                }
            }

        }

        #endregion

        /// <summary>
        /// Event that runs when the forms loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeamManagement_Load(object sender, EventArgs e)
        {
            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.dgvConfiguration();
        }

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
                this.txtCode.Text = this.AuxTeam.code.Trim();
                this.txtName.Text = this.AuxTeam.name.Trim();

                //The grid with all the employees on team will load.
                this.fillDataGrid();
                this.fillComboFilterEmployees();

                this.btnDeleteTeam.Enabled = true;
                this.btnUpdateTeam.Enabled = true;
                this.btnCreateTeam.Enabled = false; // We disable the button to create a team
                this.txtCode.Enabled = false;
            }
            else
            {
                this.btnCreateTeam.Enabled = true;
                this.txtCode.Enabled = true;
                this.btnDeleteTeam.Enabled = false;
                this.btnUpdateTeam.Enabled = false;
            }

            this.dgvEmployeesOnTeam.Refresh();

            this._blHelp = false;

        }

        /// <summary>
        /// Event that runs when tre form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeamManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AuxEmployee = null;
            this.AuxTeam = null;
            //this.btnClear_Click(sender, e);
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

                //this.btnAddToTeam.Enabled = true;
                this.btnDeleteToTeam.Enabled = true;
            }
        }

        /*/// <summary>
        /// Event that runs when the button clear is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Note: he tenido que agregarlo porque el datagrid no se reseteaba con la funcion del generico. 
            //He probado de añadirle la condicion del datagridview pero no ha hecho nada.
            // Ya esta arreglado
            this.clearValues();

            /*kDELETE: Cristina C. Ya lo hace el boton generico
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
    */
        /// <summary>
        /// Event that rusn when the button delete to team is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteToTeam_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oSelectedEmployee = null;

            if (this.dgvEmployeesOnTeam.SelectedRows.Count == 1)//If the row selected
            {
                int _iIndexSelected = this.dgvEmployeesOnTeam.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = this.dgvEmployeesOnTeam.Rows[_iIndexSelected].Cells[1].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif

                    this.deleteFromTeam(_oSelectedEmployee, AuxTeam);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented.\n# Poner ventana con los employees y el que se seleccione se añada");
            //Controller.EmployeeView.ShowDialog();
        }

        /// <summary>
        /// Method that configurates the datagridview
        /// </summary>
        private void dgvConfiguration()
        {
            this.fillDataGrid();

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
        }

        /*/// <summary>
        /// Clear values of textboxs
        /// </summary>
        private void clearValues()
        {
            this.AuxEmployee = null;
            this.AuxTeam = null;
            this.dgvEmployeesOnTeam.DataSource = null;
            this.dgvConfiguration();
            this.dgvEmployeesOnTeam.Refresh();

        }*/

        /// <summary>
        /// Method that configures the datagrid of employees in Team
        /// </summary>
        private void fillDataGrid()
        {
            BindingSource source = new BindingSource();
            //if (this.dgvEmployeesOnTeam.DataSource == null) source.DataSource = new List<String>();
            if (this.AuxTeam != null)
            {
                source.DataSource = this.Controller.TeamHistoryService.getAllTeamHistoriesByTeam(this.AuxTeam.code);
            }
            this.dgvEmployeesOnTeam.DataSource = source;
            this.dgvEmployeesOnTeam.Refresh();
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

        /// <summary>
        /// Deleted selected employee to team
        /// </summary>
        private void deleteFromTeam(model.pojo.Employee pEmployee, model.pojo.Team pTeam)
        {
            //model.pojo.TeamHistory _oTeamHistory = new model.pojo.TeamHistory();
            model.pojo.TeamHistory _oTeamHistoryControl = null;

            if (pEmployee != null && pTeam != null)
            {
                _oTeamHistoryControl = this.Controller.TeamHistoryService.readTeamHistory(pEmployee.nif, pTeam.code);

                if (_oTeamHistoryControl != null)
                {
                    //USELESS
                    //_oTeamHistory.id_employee = pEmployee.nif;
                    //_oTeamHistory.id_team = pTeam.code;
                    //_oTeamHistory.entranceDay = DateTime.Today;

                    Boolean _blUpdateHistory = this.Controller.TeamHistoryService.updateTeamHistory(pEmployee.nif, pTeam.code, DateTime.Now);
                    clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.EXCLUDE, "employee", _blUpdateHistory, this);

                }
                else
                {
                    MessageBox.Show("This employee is already in the team");
                }
            }
        }

        #region HELP

        private Boolean _blHelp = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, EventArgs e)
        {
            if (_blHelp)
            {
                _blHelp = false;
                this.Height = 460;
                this.changeIconMessage(0);
                this.lblHelpMessage.Text = "";
                this.walkingControls();
            }
            else
            {
                _blHelp = true;
                this.Height = 520;
                this.walkingControls();
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
                this.lblHelpMessage.Text = null;
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
                if (sender.Equals(lblCode) || sender.Equals(txtCode))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Codigo de equipo";
                }
                else if (sender.Equals(lblName) || sender.Equals(txtName))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Nombre del del equipo.";
                }
                else if (sender.Equals(btnCreateTeam))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicke aquí para crear un nuevo equipo.";
                }
                else if (sender.Equals(btnUpdateTeam))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicke aquí para modificar los datos del equipo.";
                }
                else if (sender.Equals(btnDeleteTeam))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicke aquí para para eliminar el equipo.";
                }
                else if (sender.Equals(btnClear))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicke aquí para limpiar los valores del formulario.";
                }
                else if (sender.Equals(btnBack))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicke aquí para volver al menú principal.";
                }
                else if (sender.Equals(lblFilterEmployee) || sender.Equals(cmbFilterEmployees))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Filtrar empleados por";
                }
                else if (sender.Equals(btnAdd))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicka aquí para añadir al equipo";
                }
                else if (sender.Equals(btnDeleteToTeam))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Clicka aquí para eliminar del equipo";
                }

            }
        }

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

/*DELETE: Cristina C. 21/05/2016 Move to generic button
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
    }*/

