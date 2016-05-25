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
using SynUp_Desktop.utilities;
using SynUp_Desktop.model.pojo;

namespace SynUp_Desktop.views
{
    /// <summary>
    /// Form of manage tasks
    /// </summary>
    /// <Author>Cristina Caballero</Author>
    public partial class frmTaskManagement : Form
    {
        private Controller controller;
        private model.pojo.Task auxTask;
        private Boolean _blHelp;
        //private int minHeight = 570;
        //private int maxHeight = 590;

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

        public model.pojo.Task AuxTask
        {
            get
            {
                return auxTask;
            }

            set
            {
                auxTask = value;
            }
        }

        public frmTaskManagement()
        {
            InitializeComponent();
            
        }

        #region CRUD

        /// <summary>
        /// Event that runs when the button is clicked to create a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <Author>Cristina C.</Author>
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            String _strCode = txtCode.Text;
            String _strIdTeam = (String)cbIdTeams.SelectedValue;
            String _strProject = txtProject.Text;
            String _strName = txtName.Text;
            String _strDescription = txtDescription.Text;
            String _strLocalization = txtLocalization.Text;
            DateTime _dtPriorityDate = mcalPriorityDate.SelectionStart.Date;

            int _nImportance = 0;
            if (cbImportance.SelectedItem != null && !cbImportance.Equals(" ")) _nImportance = Int32.Parse(cbImportance.SelectedItem.ToString());

            Boolean _blCreate = false;

            if (checkCorrectValues())
            {
                _blCreate = Controller.TaskService.createTask(_strCode, _strName, _dtPriorityDate, _strDescription,
                                                             _strLocalization, _strProject, _strIdTeam, _nImportance);

                //clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.CREATE, "task", _blCreate, this);
            }

        }


        /// <summary>
        /// Event that runs when the button is clicked to delete a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Boolean _blDelete = false;

            if (Util.confirmationDialog(Literal.CONFIRMATION_DELETE_TASK, this.Text))
            {

                model.pojo.Task deleteTask = Controller.TaskService.deleteTask(AuxTask);

                if (deleteTask != null)
                {
                    _blDelete = true;
                }
                else
                {
                    _blDelete = false;
                }

                //clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.DELETE, "task", _blDelete, this);
            }
        }

        /// <summary>
        /// Event that runs when the button is clicked to update a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            String _strCode = txtCode.Text;
            String _strIdTeam = (String)cbIdTeams.SelectedValue;
            String _strProject = txtProject.Text;
            String _strName = txtName.Text;
            String _strDescription = txtDescription.Text;
            String _strLocalization = txtLocalization.Text;
            DateTime _dtPriorityDate = mcalPriorityDate.SelectionStart.Date;

            int _nImportance = Int32.Parse(cbImportance.SelectedItem.ToString());

            Boolean _blUpdate = false;

            if (checkCorrectValues())
            {
                if (Util.confirmationDialog(Literal.CONFIRMATION_UPDATE_TASK, this.Text))
                {
                    _blUpdate = Controller.TaskService.updateTask(_strCode, _strName, _dtPriorityDate,
                                                               _strDescription, _strLocalization,
                                                               _strProject, _strIdTeam, _nImportance);

                    //clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.UPDATE, "task", _blUpdate, this);
                }
            }
        }

        #endregion

        #region VALIDATIONS        

        #region TEXT CHANGED EVENTS        

        /// <summary>
        /// Even that runs everytime the Code textbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            this.checkCode();
        }

        /// <summary>
        /// Even that runs everytime the Name textbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.checkName();
        }

        /// <summary>
        /// Event that runs when date changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcalPriorityDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mcalPriorityDate.SelectionStart.Date < DateTime.Today || mcalPriorityDate.SelectionStart == null)
            {
                lblPriorityDate.ForeColor = Color.Red;
            }
            else
            {
                lblPriorityDate.ForeColor = Color.Black;
            }
        }

        #endregion

        /// <summary>
        /// Checks whether the values are correct or not depending of the validations performed.
        /// </summary>
        /// <returns></returns>
        private bool checkCorrectValues()
        {
            bool _correct = checkName() && checkCode();

            if (!_correct) this.HelpMessage(Literal.ERROR_VALIDATION_TASK, (int)utilities.Help.HelpIcon.ERROR);

            return _correct;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool checkCode()
        {
            if (AuxTask == null)
            {
                String _strIdCode = txtCode.Text;
                model.pojo.Task foundTask = Controller.TaskService.readTask(_strIdCode); // We look for if the task already exists

                if (txtCode.Text.Equals("") || foundTask != null) // If the task exists and the string is empty, we show a message
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
        /// 
        /// </summary>
        /// <returns></returns>
        private bool checkName()
        {
            if (txtName.Text.Equals("") || txtName.Text == null) // If the name is empty, we show a message
            {
                lblName.ForeColor = Color.Red;
                return false;
            }
            else
            {
                lblName.ForeColor = Color.Black;
                return true;
            }
        }

        #endregion        

        /// <summary>
        /// Event that runs when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaskManagement_Load(object sender, EventArgs e)
        {

            cbIdTeams.DataSource = Controller.TeamService.getAllTeams();
            cbIdTeams.DisplayMember = "Name";
            cbIdTeams.ValueMember = "Code";

            cbIdTeams.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImportance.DropDownStyle = ComboBoxStyle.DropDownList;

            if (AuxTask != null)
            {
                // We recover the data of selected task
                //selecteditem
                if (this.AuxTask.id_team != null) this.cbIdTeams.SelectedItem = cbIdTeams.FindString(this.AuxTask.id_team.Trim());
                else cbIdTeams.SelectedIndex = -1;

                MessageBox.Show(cbIdTeams.SelectedIndex.ToString());
                MessageBox.Show(this.AuxTask.id_team.Trim());

                this.cbImportance.SelectedIndex = (int)this.AuxTask.priority;
                this.txtCode.Text = this.AuxTask.code;
                this.txtName.Text = this.AuxTask.name;
                this.txtDescription.Text = this.AuxTask.description;
                this.txtLocalization.Text = this.AuxTask.localization;
                this.mcalPriorityDate.SelectionStart = this.AuxTask.priorityDate;
                this.txtProject.Text = this.AuxTask.project;
                this.txtState.Text = ((TaskState)this.AuxTask.state).ToString(); //getState(AuxTask);

                btnCreateTask.Enabled = false;
                txtCode.Enabled = false;

                btnUpdateTask.Enabled = true;
                btnDeleteTask.Enabled = true;
            }
            else
            {
                btnUpdateTask.Enabled = false;
                btnDeleteTask.Enabled = false;

                btnCreateTask.Enabled = true;
                txtCode.Enabled = true;
            }

            ///Sets the tooltips for the view
            ///Nota: Interesante poner las restricciones de la base de datos directamente.
            //ToolTip ToolTips = new ToolTip();
            //ToolTip1.IsBalloon = true;
            //ToolTips.SetToolTip(this.lblCode, "Task code.");
            //ToolTips.SetToolTip(lblDescription, "Description of the task.");

            this._blHelp = false;

            utilities.Util.loadMenu(this, this.controller);
        }

        /// <summary>
        /// Event that runs when the form's closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaskManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            AuxTask = null;
            _blHelp = false;
        }

        /// <summary>
        /// Event thnat runs when the button clear is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            AuxTask = null;
            _blHelp = utilities.Help.hideShowHelp(true, this, this.MinimumSize.Height, this.MaximumSize.Height);
        }

        #region HELP        

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {
            _blHelp = utilities.Help.hideShowHelp(_blHelp, this, this.MinimumSize.Height, this.MaximumSize.Height);
            if (_blHelp) this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
            this.walkingControls();
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
                    _message = Literal.INFO_CODE_TASK;
                }
                else if (sender.Equals(lblName) || sender.Equals(txtName))
                {
                    _message = Literal.INFO_NAME_TASK;
                }
                else if (sender.Equals(lblLocalization) || sender.Equals(txtLocalization))
                {
                    _message = Literal.INFO_LOCATION_TASK;
                }
                else if (sender.Equals(lblProject) || sender.Equals(txtProject))
                {
                    _message = Literal.INFO_PROJECT_TASK;
                }
                else if (sender.Equals(lblPriorityDate) || sender.Equals(mcalPriorityDate))
                {
                    _message = Literal.INFO_DATE_TASK;
                }
                else if (sender.Equals(lblDescription) || sender.Equals(txtDescription))
                {
                    _message = Literal.INFO_DESC_TASK;
                }
                else if (sender.Equals(lblState) || sender.Equals(txtState))
                {
                    _message = Literal.INFO_STATE_TASK;
                }
                else if (sender.Equals(lblImportance) || sender.Equals(cbImportance))
                {
                    _message = Literal.INFO_IMPORTANCE_TASK;
                }
                else if (sender.Equals(lblIdTeam) || sender.Equals(cbIdTeams))
                {
                    _message = Literal.INFO_IDTEAM_TASK;
                }
                else if (sender.Equals(btnCreateTask))
                {
                    _message = Literal.INFO_BTN_CREATE;
                }
                else if (sender.Equals(btnUpdateTask))
                {
                    _message = Literal.INFO_BTN_UPDATE;
                }
                else if (sender.Equals(btnDeleteTask))
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
                this.HelpMessage(_message, _icon);
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
                    foreach (Control _inGroupBox in _control.Controls) //Recorremos los componentes del groupbox
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

#region DEPRECATED METHODS

//private string getState(model.pojo.Task _task)
//{
//    string state = "";
//    switch (_task.state)
//    {
//        case (int)TaskState.UNSELECTED:
//            state = "Unselected";
//            break;
//        case (int)TaskState.ONGOING:
//            state = "Ongoing";
//            break;
//        case (int)TaskState.ABANDONED:
//            state = "Abandoned";
//            break;
//        case (int)TaskState.FINISHED:
//            state = "Finished";
//            break;
//        case (int)TaskState.CANCELLED:
//            state = "Cancelled";
//            break;
//    }
//    return state;
//}

/// <summary>
/// Event that runs when the button clear is clicked - DEPRECATED, Pablo - 22/05/16
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
//private void btnClear_Click(object sender, EventArgs e)
//{
//    this.clearValues();

//    if (this.btnCreateTask.Enabled == false)
//    {
//        this.btnCreateTask.Enabled = true;
//        this.btnDeleteTask.Enabled = false;
//        this.btnUpdateTask.Enabled = false;
//        this.AuxTask = null;
//        if (txtCode.Enabled == false) txtCode.Enabled = true;
//    }
//}

/// <summary>
/// Method that cleans values - DEPRECATED, Pablo - 22/05/16 // Generic button does the work
/// </summary>
//private void clearValues()
//{
//    //txtIdTeam.Text = "";

//    //cbIdTeams.SelectedIndex = 0;
//    txtCode.Text = "";
//    txtProject.Text = "";
//    txtName.Text = "";
//    txtDescription.Text = "";
//    txtLocalization.Text = "";
//    mcalPriorityDate.SelectionStart = DateTime.Today;
//    mcalPriorityDate.SelectionEnd = DateTime.Today;
//}

/// <summary>
/// Event that runs when the button is clicked to return back - DEPRECATED, Pablo - 22/05/16
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
//private void btnBack_Click(object sender, EventArgs e)
//{
//    this.AuxTask = null;
//    this.clearValues();
//    this.Close();
//}

///// <summary>
///// Even that runs everytime the IdTeam textbox is changed
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtIdTeam_TextChanged(object sender, EventArgs e)
//{
//    if (txtIdTeam.Text != "")
//    {
//        String _iIdTeam = txtIdTeam.Text;

//        model.pojo.Team _oTeam = Controller.TeamService.readTeam(_iIdTeam); // We look for if the team already exists

//        if (_oTeam == null) // If the team exists, we show a message
//        {
//            //MessageBox.Show("This team don't exists");
//            lblIdTeam.ForeColor = Color.Red;
//            lblIdTeam.Text = "Id Team*";
//        }
//        else
//        {
//            lblIdTeam.ForeColor = Color.Black;
//            lblIdTeam.Text = "Id Team";
//        }

//    }
//}

///// <summary>
/////  Event that runs when the focus leaves the textbox
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtCode_Leave(object sender, EventArgs e)
//{
//    //if (txtCode.Text.Equals("")) // We found that the textbox is not emtpty
//    //{
//    //    lblCode.ForeColor = Color.Red;
//    //    lblCode.Text = "Code*";
//    //    //txtCode.Focus();
//    //    //MessageBox.Show("The code can not be empty!");
//    //}

//    //String _strIdCode = txtCode.Text;
//    //model.pojo.Task foundTask = Controller.TaskService.readTask(_strIdCode); // We look for if the task already exists

//    //if (foundTask != null) // If the task exists, we show a message
//    //{
//    //    MessageBox.Show("This code already exists");
//    //}

//}

///// <summary>
///// Event that runs when the textbox recibes the focus
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtCode_Enter(object sender, EventArgs e)
//{
//    //lblCode.Text = "Code";
//    //lblCode.ForeColor = Color.Black;
//}

///// <summary>
///// Event that runs when the focus leaves the textbox
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtName_Leave(object sender, EventArgs e)
//{

//}

///// <summary>
///// Event that runs when the textbox recibes the focus
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtName_Enter(object sender, EventArgs e)
//{
//    lblName.Text = "Name";
//    lblName.ForeColor = Color.Black;
//}
///// <summary>
/////  Event that runs when the focus leaves the idTeam
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtIdTeam_Leave(object sender, EventArgs e)
//{
//    //if (txtIdTeam.Text != "")
//    //{
//    //    String _iIdTeam = txtIdTeam.Text;
//    //    model.pojo.Team _oTeam = Controller.TeamService.readTeam(_iIdTeam); // We look for if the team already exists

//    //    if (_oTeam == null) // If the team exists, we show a message
//    //    {
//    //        MessageBox.Show("This team don't exists");
//    //        lblIdTeam.ForeColor = Color.Red;
//    //        lblIdTeam.Text = "Id Team*";
//    //    }

//    //}
//}

///// <summary>
///// Event that runs when the textbox recibes the focus
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void txtIdTeam_Enter(object sender, EventArgs e)
//{
//    lblIdTeam.Text = "Id Team";
//    lblIdTeam.ForeColor = Color.Black;
//}


/* Moved to Util 230516 Pablo Ardèvol
    /// <summary>
    /// Confirmation dialog that will let the user confirm they action or cancel it.
    /// </summary>
    /// <param name="message"></param>
    /// <returns>Button click</returns>
    private bool confirmationDialog(string message)
    {
        return (MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
    }
    */

/* DELETED AND MOVED TO utilities.Help -- 230516 Pablo Ardèvol
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

/* CHANGED BY HELPMESSAGE 23/05/16 - Pablo Ardèvol
/// <summary>
/// Methd that sohws message wrong
/// </summary>
private void messageWrong()
{
this.Height = 360;
this.changeIconMessage(2);
this.lblHelpMessage.Text = "El nif i/o el email no puede estar vacío.";
}
*/

#endregion
