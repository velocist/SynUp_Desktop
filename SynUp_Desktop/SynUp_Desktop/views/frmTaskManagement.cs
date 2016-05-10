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
            model.pojo.Task deleteTask = Controller.TaskService.deleteTask(AuxTask);
            if (deleteTask != null)
            {
                MessageBox.Show("This task was delete succesfully");
                this.btnBack_Click(sender, e);
            }
            else {
                MessageBox.Show("This task wasn't delete succesfully");
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

            Boolean _blUpdateOk = Controller.TaskService.updateTask(_strCode, _strName, _dtPriorityDate, _strDescription, _strLocalization, _strProject, _strIdTeam);

            if (_blUpdateOk)
            {
                MessageBox.Show("The task was updated succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The task wasn't updated.");
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

            Boolean createOk = Controller.TaskService.createTask(_strCode, _strName, _dtPriorityDate, _strDescription, _strLocalization, _strProject, _strIdTeam);
            MessageBox.Show(_strIdTeam);

            if (createOk)
            {
                MessageBox.Show("The task was created succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The task wasn't created!");
            }

        }

        #endregion

        #region VALIDATIONS

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
        //    //TODO: Falta comprobar porque no se inserta el idTeam al insertar la Tasca --> PORQUE TEAM NO EXISTE I ES UNA FK
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

        #region TEXT CHANGED EVENTS 
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

        /// <summary>
        /// Even that runs everytime the Code textbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            String _strIdCode = txtCode.Text;
            model.pojo.Task foundTask = Controller.TaskService.readTask(_strIdCode); // We look for if the task already exists

            if (foundTask != null || txtCode.Text.Equals("")) // If the task exists, we show a message
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

        /// <summary>
        /// Even that runs everytime the Name textbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("")) // If the name is empty, we show a message
            {
                lblName.Text = "Name*";
                lblName.ForeColor = Color.Red;
            }
            else
            {
                lblName.Text = "Name";
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
            if (mcalPriorityDate.SelectionStart.Date < DateTime.Today)
            {
                //mcalPriorityDate.Focus();
                lblPriorityDate.ForeColor = Color.Red;
                lblPriorityDate.Text = "Priority Date*";
                //MessageBox.Show("The date can not be past!");
            }
            else
            {
                lblPriorityDate.ForeColor = Color.Black;
                lblPriorityDate.Text = "Priority Date";
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.AuxTask = null;
            this.clearValues();
            this.Close();
        }

        /// <summary>
        /// Event that runs when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaskManagement_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();
            cbIdTeams.DataSource = source;
            cbIdTeams.DisplayMember = "Name";
            cbIdTeams.ValueMember = "Code";

            if (AuxTask != null)
            {
                // We recover the data of selected task
                //this.txtIdTeam.Text = Convert.ToString(this.AuxTask.id_team);
                this.txtCode.Text = Convert.ToString(this.AuxTask.code);
                this.txtName.Text = this.AuxTask.name;
                this.txtDescription.Text = this.AuxTask.description;
                this.txtLocalization.Text = this.AuxTask.localization;
                this.mcalPriorityDate.SelectionStart = this.AuxTask.priorityDate;
                this.txtProject.Text = this.AuxTask.project;

                this.btnCreateTask.Enabled = false; // We disable the button to create a task
                this.txtCode.Enabled = false;
            } else
            {
                this.btnCreateTask.Enabled = true;
                this.txtCode.Enabled = true;
            }

            ///Sets the tooltips for the view
            ///Nota: Interesante poner las restricciones de la base de datos directamente.
            ToolTip ToolTips = new ToolTip();
            //ToolTip1.IsBalloon = true;
            ToolTips.SetToolTip(this.lblCode, "Task code.");
            ToolTips.SetToolTip(lblDescription, "Description of the task.");
        }

        /// <summary>
        /// Event that runs when the button clear is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearValues();

            if (this.btnCreateTask.Enabled == false)
            {
                this.btnCreateTask.Enabled = true;
                this.AuxTask = null;
                if (txtCode.Enabled == false) txtCode.Enabled = true;
            }
        }

        /// <summary>
        /// Method that cleans values
        /// </summary>
        private void clearValues()
        {
            //txtIdTeam.Text = "";
            
            //cbIdTeams.SelectedIndex = 0;
            txtCode.Text = "";
            txtProject.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtLocalization.Text = "";
            mcalPriorityDate.SelectionStart = DateTime.Today;
            mcalPriorityDate.SelectionEnd = DateTime.Today;
        }

    }
}
