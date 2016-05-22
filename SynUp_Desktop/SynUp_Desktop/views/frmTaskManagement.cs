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

namespace SynUp_Desktop.views
{
    /// <summary>
    /// Form of manage tasks
    /// </summary>
    /// <Author>Cristina Caballero</Author>
    public partial class frmTaskManagement : Form
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

        public frmTaskManagement()
        {
            InitializeComponent();
        }

        public model.pojo.Task AuxTask;

        #region CRUD

        /// <summary>
        /// Event that runs when the button is clicked to delete a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Boolean _blDelete = false;

            if (confirmationDialog("Are you sure you want to cancel this task?"))
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

                clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.DELETE, "task", _blDelete, this);
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

            //int _nImportance = (int)Int32.TryParse(cbImportance.SelectedItem);

            Boolean _blUpdate = false;

            if (checkCorrectValues())
            {
                if (confirmationDialog("Are you sure you want to update this task?"))
                {
                    _blUpdate = Controller.TaskService.updateTask(_strCode, _strName, _dtPriorityDate,
                                                               _strDescription, _strLocalization,
                                                               _strProject, _strIdTeam, _nImportance);

                    clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.UPDATE, "task", _blUpdate, this);
                }
            }
        }

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

                clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.CREATE, "task", _blCreate, this);
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
            if (AuxTask == null)
            {
                String _strIdCode = txtCode.Text;
                model.pojo.Task foundTask = Controller.TaskService.readTask(_strIdCode); // We look for if the task already exists

                if (!checkCode() || foundTask != null) // If the task exists and the string is empty, we show a message
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

        /// <summary>
        /// Even that runs everytime the Name textbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!checkName() || txtName.Text == null) // If the name is empty, we show a message
            {
                //lblName.Text = "Name*";
                lblName.ForeColor = Color.Red;
            }
            else
            {
                //lblName.Text = "Name";
                lblName.ForeColor = Color.Black;
            }
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
                //lblPriorityDate.Text = "Priority Date*";
            }
            else
            {
                lblPriorityDate.ForeColor = Color.Black;
                //lblPriorityDate.Text = "Priority Date";
            }
        }

        #endregion

        /// <summary>
        /// Checks whether the values are correct or not depending of the validations performed.
        /// </summary>
        /// <returns></returns>
        private bool checkCorrectValues()
        {
            bool _correct = false;
            if (lblCode.ForeColor != Color.Red && checkCode() && checkName() && lblName.ForeColor != Color.Red/* && lblPriorityDate.ForeColor != Color.Red*/)
            {
                if (AuxTask != null || lblPriorityDate.ForeColor != Color.Red)
                {
                    _correct = true;
                }
            }

            //clMessageBox.showMessageAction(clMessageBox.ACTIONTYPE.CREATE, "employee", _blCreateOk, this);

            if (!_correct) clMessageBox.showMessage(clMessageBox.MESSAGE.WRONG, null, this);

            return _correct;
        }

        private bool checkCode()
        {
            return !txtCode.Text.Equals("");
        }

        private bool checkName()
        {
            return !txtName.Text.Equals("");
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
                if (this.AuxTask.id_team != null) this.cbIdTeams.SelectedIndex = cbIdTeams.FindString(this.AuxTask.id_team.Trim());
                this.cbImportance.SelectedIndex = (int)this.AuxTask.priority;

                this.txtCode.Text = this.AuxTask.code;
                this.txtName.Text = this.AuxTask.name;
                this.txtDescription.Text = this.AuxTask.description;
                this.txtLocalization.Text = this.AuxTask.localization;
                this.mcalPriorityDate.SelectionStart = this.AuxTask.priorityDate;
                this.txtProject.Text = this.AuxTask.project;
                this.txtState.Text = ((TaskState)this.AuxTask.state).ToString(); //getState(AuxTask);

                //lblCode.Text = "Code*";
                //lblName.Text = "Name*";

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
        }        

        private void frmTaskManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            AuxTask = null;
            //btnClear_Click(sender, e);
        }

        /// <summary>
        /// Confirmation dialog that will let the user confirm they action or cancel it.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Button click</returns>
        private bool confirmationDialog(string message)
        {
            return (MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AuxTask = null;
            lblCode.ForeColor = Color.Red;
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

        #endregion

    }
}
