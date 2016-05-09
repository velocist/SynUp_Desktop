using SynUp_Desktop.controller;
using SynUp_Desktop.model.pojo;
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
    public partial class frmEmployeeManagement : Form
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
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        public Employee AuxEmployee;

        #region CRUD

        /// <summary>
        /// Event that runs when the button is clicked to create a employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <Author>Cristina C.</Author>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            String _strNif = txtNif.Text;
            String _strName = txtName.Text;
            String _strSurname = txtSurname.Text;
            String _strPhone = txtPhone.Text;
            String _strEmail = txtEmail.Text;
            String _strAdress = txtAdress.Text;

            Boolean _blCreateOk = this.Controller.EmployeeService.createEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress);

            if (_blCreateOk)
            {
                MessageBox.Show("The employee was created succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The employee wasn't created succesfully!");
            }
        }

        /// <summary>
        /// Event that runs when the button is clicked to update a employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            String _strNif = txtNif.Text;
            String _strName = txtName.Text;
            String _strSurname = txtSurname.Text;
            String _strPhone = txtPhone.Text;
            String _strEmail = txtEmail.Text;
            String _strAdress = txtAdress.Text;

            Boolean _blUpdateOk = this.Controller.EmployeeService.updateEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress);

            if (_blUpdateOk)
            {
                MessageBox.Show("The employee was updated succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The employee wasn't updated succesfully!");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oDeleteEmployee = this.Controller.EmployeeService.deleteEmployee(AuxEmployee);

            if (_oDeleteEmployee != null)
            {
                MessageBox.Show("This employee was delete succesfully");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("This employee wasn't delete succesfully");
            }
        }

        #endregion

        #region VALIDATIONS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            if (txtNif.Text != "")
            {
                String _strNif = txtNif.Text;

                model.pojo.Employee _oEmployee = this.Controller.EmployeeService.readEmployee(_strNif); // We look for if the team already exists

                if (_oEmployee == null) // If the team exists, we show a message
                {
                    //MessageBox.Show("This team don't exists");
                    lblNif.ForeColor = Color.Red;
                    lblNif.Text = "Id Team*";
                }
                else
                {
                    lblNif.ForeColor = Color.Black;
                    lblNif.Text = "Id Team";
                }

            }
        }

        #endregion

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.AuxEmployee = null;
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

            if (this.btnCreate.Enabled == false)
            {
                this.btnCreate.Enabled = true;
                this.AuxEmployee = null;
                if (txtNif.Enabled == false) txtNif.Enabled = true;
            }
        }

        /// <summary>
        /// Method that cleans values
        /// </summary>
        private void clearValues()
        {
            txtNif.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAdress.Text = "";
        }

    }
}
