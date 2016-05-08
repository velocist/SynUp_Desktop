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

        #region CRUD

        /// <summary>
        /// Event that runs when the button is clicked to delete a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event that runs when the button is clicked to update a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateTask_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event that runs when the button is clicked to create a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <Author>Cristina C.</Author>
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            //TODO Falta mirar que si se inserta un idTeam, este exista antes de insertar la tasca assignada al team
            String _iIdTeam = txtIdTeam.Text;
            String _idCode = txtCode.Text;
            String _strProject = txtProject.Text;
            String _strName = txtName.Text;
            String _strDescription = txtDescription.Text;
            String _strLocalization = txtLocalization.Text;
            DateTime _dtPriorityDate = mcalPriorityDate.SelectionStart.Date;

            Boolean createOk = TaskService.createTask(_idCode, _strName, _dtPriorityDate, _strDescription, _strLocalization, _strProject);

            if (createOk)
            {
                MessageBox.Show("The task was created succesfully!");
                clearValues();
                this.Controller.TaskMgtView1.Close();
            }
            else
            {
                MessageBox.Show("The task wasn't created succesfully!");

            }
        }

        #endregion

        #region Validaciones Obligatorios

        /// <summary>
        ///  Event that runs when the focus leaves the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(""))
            {
                lblCode.ForeColor = Color.Red;
                lblCode.Text = "Code *";
                //txtCode.Focus();
                //MessageBox.Show("The code can not be empty!");
            }
        }

        /// <summary>
        /// Event that runs when the textbox recibes the focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_Enter(object sender, EventArgs e)
        {
            lblCode.Text = "Code";
            lblCode.ForeColor = Color.Black;
        }

        /// <summary>
        /// Event that runs when the focus leaves the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                //txtName.Focus();
                lblName.ForeColor = Color.Red;
                lblName.Text = "Name *";
                //MessageBox.Show("The name can not be empty!");
            }
        }

        /// <summary>
        /// Event that runs when the textbox recibes the focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Enter(object sender, EventArgs e)
        {
            lblName.Text = "Name";
            lblName.ForeColor = Color.Black;
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
                lblPriorityDate.Text = "Priority Date *";
                MessageBox.Show("The date can not be last!");
            }
        }

        /// <summary>
        /// Event that runs when date selects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcalPriorityDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblPriorityDate.Text = "Priority Date";
            lblPriorityDate.ForeColor = Color.Black;
        }

        #endregion

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method that cleans values
        /// </summary>
        private void clearValues()
        {
            txtIdTeam.Text = "";
            txtCode.Text = "";
            txtProject.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtLocalization.Text = "";
            mcalPriorityDate.SelectionStart = DateTime.Today;
        }

    }
}
