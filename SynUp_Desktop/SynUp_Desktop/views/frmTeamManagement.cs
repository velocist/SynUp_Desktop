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

        private Team auxTeam;
        private Employee auxEmployee;
        private Boolean _blHelp = false;
        private int minHeight;
        private int maxHeight;
        //private Boolean blAllAddCorrects;

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

        public Employee AuxEmployee
        {
            get
            {
                return auxEmployee;
            }

            set
            {
                auxEmployee = value;
            }
        }

        public frmTeamManagement()
        {
            InitializeComponent();
            minHeight = this.MinimumSize.Height;
            maxHeight = this.MaximumSize.Height;

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

            if (validateValues())
            {
                Boolean _blCreate = Controller.TeamService.createTeam(_strCode, _strName);
                if (_blCreate)
                {
                    clMessageBox.showMessage(Literal.CREATE_TEAM_CORRETLY, true, this);
                    if ((((System.Windows.Forms.Control)sender).Name).Equals("btnAdd"))
                    {
                        //blAllAddCorrects = true;
                        AuxTeam = Controller.TeamService.readTeam(_strCode);
                    }
                }
                else
                {
                    clMessageBox.showMessage(Literal.CREATE_TEAM_FAILED, false, this);
                    //blAllAddCorrects = false;
                }
            }
        }

        /// <summary>
        /// Event that runs when the button delete is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {

            if (clMessageBox.confirmationDialog(Literal.CONFIRMATION_DELETE_TEAM, this.Text))
            {
                Team deleteTeam = Controller.TeamService.deleteTeam(AuxTeam);
                if (deleteTeam != null)
                {
                    clMessageBox.showMessage(Literal.DELETE_TEAM_CORRETLY, true, this);
                }
                else
                {
                    clMessageBox.showMessage(Literal.DELETE_TEAM_FAILED, false, this);
                }
            }

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

            if (validateValues())
            {
                if (clMessageBox.confirmationDialog(Literal.CONFIRMATION_UPDATE_TEAM, this.Text))
                {
                    Boolean _blUpdate = this.Controller.TeamService.updateTeam(_strCode, _strName);

                    if (_blUpdate)
                    {
                        clMessageBox.showMessage(Literal.UPDATE_TEAM_CORRETLY, true, this);
                    }
                    else
                    {
                        clMessageBox.showMessage(Literal.UPDATE_TEAM_FAILED, false, this);
                    }
                }
            }
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
            this.checkCode();
        }

        /// <summary>
        /// Method that checks if the code is correct
        /// </summary>
        /// <returns></returns>
        private bool checkCode()
        {
            if (this.AuxTeam == null)
            {
                String _strIdCode = txtCode.Text;
                Team _oTeam = Controller.TeamService.readTeam(_strIdCode);

                if (txtCode.Text.Equals("") || _oTeam != null) // We found that the textbox is not empty
                {
                    lblCode.ForeColor = Color.Red;
                    return false;
                }
                else
                {
                    lblCode.ForeColor = Color.Black;
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// MEthod that validate form values
        /// </summary>
        /// <returns></returns>
        private bool validateValues()
        {
            bool _valid = checkCode();

            if (!_valid) this.HelpMessage(Literal.ERROR_VALIDATION_TEAM, (int)utilities.Help.HelpIcon.ERROR);

            return _valid;
        }

        #endregion

        #region FORM EVENTS

        /// <summary>
        /// Event that runs when the forms loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeamManagement_Load(object sender, EventArgs e)
        {
            this.frmTeamManagement_Activated(sender, e);

            utilities.Help.walkingControls(this, this.messageHelps_MouseHover, this.messageHelps_MouseLeave);

            this.gbContainer.MouseClick += new MouseEventHandler(this.frmTeamManagement_MouseClick);
            this.gbHelp.MouseClick += new MouseEventHandler(this.frmTeamManagement_MouseClick);

            Util.loadMenu(this, this.controller);

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

                this.enabledCreate(false); //We enabled create team
            }
            else
            {
                this.btnClear_Click(sender, e);
            }

            //The grid with all the employees on team will load.
            this.fillDataGrid();
            this.dgvConfiguration();

            _blHelp = utilities.Help.hideShowHelp(true, this, minHeight, maxHeight);
        }

        /// <summary>
        /// Event that runs when tre form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeamManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.btnClear_Click(sender, e);
        }

        /// <summary>
        /// Event that runs when mouse click on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeamManagement_MouseClick(object sender, MouseEventArgs e)
        {
            this.dgvEmployeesOnTeam.ClearSelection();
            this.dgvEmployeesOnTeam.Refresh();
        }

        /// <summary>
        /// Sets all the variables of the form to Null and empties the datagridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearForm();
            _blHelp = utilities.Help.hideShowHelp(true, this, minHeight, maxHeight);
        }

        /// <summary>
        /// Event that runs when the row changes stat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployeesOnTeam_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (this.dgvEmployeesOnTeam.SelectedRows.Count >= 1)
            {
                int _iIndexSelected = this.dgvEmployeesOnTeam.SelectedRows[0].Index;
                Object _cell = dgvEmployeesOnTeam.Rows[_iIndexSelected].Cells[1].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString();
                    this.AuxEmployee = this.Controller.EmployeeService.readEmployee(_strSelectedRowCode);
                }
                this.btnDeleteToTeam.Enabled = true;
            }
            else
            {
                this.btnDeleteToTeam.Enabled = false;
            }
        }

        /// <summary>
        /// Event that rusn when the button delete to team is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteToTeam_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oSelectedEmployee = null;
            Boolean _blAllCorrect = true;

            if (this.dgvEmployeesOnTeam.SelectedRows.Count >= 1)//If the row selected
            {
                DataGridViewSelectedRowCollection _selected = this.dgvEmployeesOnTeam.SelectedRows;

                foreach (DataGridViewRow _row in _selected)
                {
                    int _iIndexSelected = _row.Index; // Recover the index of selected row
                    Object _cell = this.dgvEmployeesOnTeam.Rows[_iIndexSelected].Cells[0].Value; //Gets the NIF
                    if (_cell != null)
                    {
                        String _strSelectedRowCode = _cell.ToString(); // Recover the code
                        _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the employee nif

                        Boolean _blDelete = this.deleteFromTeam(_oSelectedEmployee, AuxTeam);
                        if (!_blDelete) _blAllCorrect = false;
                        this.fillDataGrid();
                    }
                }
            }
            if (!_blAllCorrect) clMessageBox.showMessage(Literal.INFO_ON_TEAM, false, this); //TODO: Error al elimanar algun empleado de la lista

        }

        /// <summary>
        /// Event that runs when button add is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.addToTeam(sender, e);
        }

        #endregion

        /// <summary>
        /// Method that configurates the datagridview
        /// </summary>
        private void dgvConfiguration()
        {
            Util.dgvCommonConfiguration(this.dgvEmployeesOnTeam);
            this.dgvEmployeesOnTeam.MultiSelect = true;
        }

        /// <summary>
        /// Method that configures the datagrid of employees in Team
        /// </summary>
        private void fillDataGrid()
        {
            BindingSource source = new BindingSource();

            if (this.AuxTeam != null)
            {
                source.DataSource = this.Controller.TeamHistoryService.getMembersInATeam(this.AuxTeam.code);
            }
            this.dgvEmployeesOnTeam.DataSource = source;
            this.dgvEmployeesOnTeam.ClearSelection();
            this.dgvEmployeesOnTeam.Refresh();
        }

        /// <summary>
        /// Method that show employees list for select employees
        /// </summary>
        /// <param name="pSender"></param>
        /// <param name="pArgs"></param>
        private void addToTeam(object pSender, EventArgs pArgs)
        {
            if (AuxTeam == null)
            {
                this.btnCreateTeam_Click(pSender, pArgs);
            }
            this.Controller.EmployeeSelectionView.AuxTeam = this.AuxTeam;
            Controller.EmployeeSelectionView.ShowDialog();
        }

        /// <summary>
        /// Deleted selected employee to team
        /// </summary>
        private bool deleteFromTeam(model.pojo.Employee pEmployee, model.pojo.Team pTeam)
        {
            model.pojo.TeamHistory _oTeamHistoryControl = null;
            Boolean _blUpdateHistory = false;

            if (pEmployee != null && pTeam != null)
            {
                _oTeamHistoryControl = this.Controller.TeamHistoryService.readTeamHistory(pEmployee.nif, pTeam.code);

                if (_oTeamHistoryControl != null)
                {
                    _blUpdateHistory = this.Controller.TeamHistoryService.updateTeamHistory(pEmployee.nif, pTeam.code, DateTime.Now);

                }
            }
            return _blUpdateHistory;
        }

        /// <summary>
        /// MEthod that enableds create or update/delete
        /// </summary>
        /// <param name="pEnabled">True for enabled create</param>
        private void enabledCreate(Boolean pEnabled)
        {
            if (pEnabled)
            {
                this.txtCode.Enabled = true;
                this.btnCreateTeam.Enabled = true;
                this.btnUpdateTeam.Enabled = false;
                this.btnDeleteTeam.Enabled = false;
            }
            else
            {
                this.txtCode.Enabled = false;
                this.btnCreateTeam.Enabled = false;
                this.btnUpdateTeam.Enabled = true;
                this.btnDeleteTeam.Enabled = true;
            }

        }

        /// <summary>
        /// Method that clears form
        /// </summary>
        private void clearForm()
        {
            this.btnClear.clearFields();
            this.AuxTeam = null;
            this.AuxEmployee = null;
            this.enabledCreate(true);
        }

        #region HELP        

        /// <summary>
        /// Event that runs when the button Help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, EventArgs e)
        {
            _blHelp = utilities.Help.hideShowHelp(_blHelp, this, this.MinimumSize.Height, this.MaximumSize.Height);
            if (_blHelp) this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
        }

        /// <summary>
        /// Event that runs when the mouse leaves labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseLeave(object sender, EventArgs e)
        {
            if (_blHelp) this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
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
                int _icon = (int)utilities.Help.HelpIcon.INFORMATION;
                String _message = "";

                if (sender.Equals(lblCode) || sender.Equals(txtCode))
                {
                    _message = Literal.INFO_CODE_TEAM;
                }
                else if (sender.Equals(lblName) || sender.Equals(txtName))
                {
                    _message = Literal.INFO_NAME_TEAM;
                }
                else if (sender.Equals(btnCreateTeam))
                {
                    _message = Literal.INFO_BTN_CREATE;
                }
                else if (sender.Equals(btnUpdateTeam))
                {
                    _message = Literal.INFO_BTN_UPDATE;
                }
                else if (sender.Equals(btnDeleteTeam))
                {
                    _message = Literal.INFO_BTN_DELETE;
                }
                else if (sender.Equals(btnClear))
                {
                    _message = Literal.INFO_BTN_CLEAR;
                }
                else if (sender.Equals(btnBack))
                {
                    _message = Literal.INFO_BTN_BACK;
                }
                /*else if (sender.Equals(lblFilterEmployee) || sender.Equals(cmbFilterEmployees))
                {
                    this.changeIconMessage(3);
                    this.lblHelpMessage.Text = "Filtrar empleados por";
                }*/
                else if (sender.Equals(btnAdd))
                {
                    _message = Literal.INFO_ADD_TEAM;
                }
                else if (sender.Equals(btnDeleteToTeam))
                {
                    _message = Literal.INFO_DELETE_TEAM;
                }

                this.HelpMessage(_message, _icon);
            }
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

/* DELETED CLEARVALUES
  /// <summary>
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

/* NOT IMPLEMENTED
   /// <summary>
   /// Method that fill combobox filter of employees
   /// </summary>
   //public void fillComboFilterEmployees()
   //{
   //    this.cmbFilterEmployees.Items.Clear();
   //    this.cmbFilterEmployees.Items.Add("Current");
   //    this.cmbFilterEmployees.Items.Add("Past");
   //    this.cmbFilterEmployees.Items.Add("All");

   //    this.cmbFilterEmployees.SelectedIndex = 0;
   //}
   */

/*DELETED - CLEAR BUTTON
    /// <summary> 
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

/* DELETED MOVED TO utilities
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
   */

/*DELETES: Cristina C. 270516 Move to Help class
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
