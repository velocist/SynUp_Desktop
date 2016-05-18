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
using System.Text.RegularExpressions;
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
            String _strUsername = txtAdress.Text;


            Boolean _blCreateOk = this.Controller.EmployeeService.createEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress,_strUsername);

            /*utilities.clMessageBox _msgBox = new utilities.*//// MODIFICATION - Pablo, 170516, clMessageBox made static to access the methods without having to create an object of the class.
            clMessageBox.showMessage("create", "employee", _blCreateOk, this);

            /*if (_blCreateOk)
            {
                MessageBox.Show("The employee was created succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The employee wasn't created succesfully!");
            }*/
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
            String _strUsername = txtUsername.Text;

            Boolean _blUpdateOk = this.Controller.EmployeeService.updateEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress,_strUsername);
            clMessageBox.showMessage("update", "employee", _blUpdateOk, this);
            /*if (_blUpdateOk)
            {
                MessageBox.Show("The employee was updated succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The employee wasn't updated succesfully!");
            }*/
        }

        /// <summary>
        /// Event that runs when the button is clicked to delete a employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Boolean _blDelete = false;
            model.pojo.Employee _oDeleteEmployee = this.Controller.EmployeeService.deleteEmployee(AuxEmployee);

            if (_oDeleteEmployee != null)
            {
                _blDelete = true;
            }
            else
            {
                _blDelete = false;
            }

            clMessageBox.showMessage("delete", "employee", _blDelete, this);
        }

        #endregion

        #region VALIDATIONS

        /// <summary>
        /// Event that runs when the text is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            string _strNifExpression = "\\d{8}[a-zA-Z]";

            if (AuxEmployee == null)
            {
                string _strNif = "";
                if (txtNif.Text != null) _strNif = txtNif.Text;

                Employee _oEmployee = Controller.EmployeeService.readEmployee(_strNif); // We look for if the employee already exists

                if (_oEmployee != null || !Regex.Match(_strNif, _strNifExpression).Success && txtNif.Text != "") // If the employee exists, we show a message
                {                    
                    lblNif.ForeColor = Color.Red;
                    lblNif.Text = "NIF*";
                }
                else
                {
                    lblNif.ForeColor = Color.Black;
                    lblNif.Text = "NIF";
                }
            }
        }

        /// <summary>
        /// Event that runs when the text of email is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string _strEmailExpression = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            if (txtEmail.Text != "")
            {
                String _strEmail = txtEmail.Text;

                if (!Regex.Match(_strEmail, _strEmailExpression).Success || txtEmail.Text == "") // If the team exists, we show a message
                {
                    lblEmail.ForeColor = Color.Red;
                    lblEmail.Text = "Email*";
                }
                else
                {
                    lblEmail.ForeColor = Color.Black;
                    lblEmail.Text = "Email";
                }
            }
        }

        private void validateFields()
        {

        }
        #endregion

        /// <summary>
        /// Event that runs when the forms activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeManagement_Activated(object sender, EventArgs e)
        {

            if (AuxEmployee != null)
            {
                // We recover the data of selected employee
                this.txtNif.Text = this.AuxEmployee.nif;
                this.txtName.Text = this.AuxEmployee.name;
                this.txtSurname.Text = this.AuxEmployee.surname;
                this.txtPhone.Text = this.AuxEmployee.phone;
                this.txtEmail.Text = this.AuxEmployee.email;
                this.txtAdress.Text = this.AuxEmployee.adress;
                this.txtUsername.Text = this.AuxEmployee.username;

                this.btnCreate.Enabled = false; // We disable the button to create a task
                this.txtNif.Enabled = false;
                this.btnUpdateEmployee.Enabled = true;
                this.btnDeleteEmployee.Enabled = true;
            }
            else
            {
                this.btnCreate.Enabled = true;
                this.txtNif.Enabled = true;
                this.btnUpdateEmployee.Enabled = false;
                this.btnDeleteEmployee.Enabled = false;
            }

            this.setToolTips(); //Sets the tooltips for the view

        }

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnBack_Click(object sender, EventArgs e)
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
                this.btnUpdateEmployee.Enabled = false;
                this.btnDeleteEmployee.Enabled = false;
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
            txtUsername.Text = "";
        }

        /// <summary>
        /// Method that sets the tooltips for the view
        /// </summary>
        private void setToolTips()
        {
            ///Nota: Interesante poner las restricciones de la base de datos directamente.
            ToolTip ToolTips = new ToolTip();
            //ToolTip1.IsBalloon = true;
            ToolTips.SetToolTip(this.lblNif, "NIF Employee.\n[00000000-A]");
            ToolTips.SetToolTip(this.lblPhone, "+(00)000000000\n or 000000000");
            ToolTips.SetToolTip(this.lblEmail, "exemple@domain.com");

        }
        

        /* DELETE: Cambio por el evento Activated
       /// <summary>
       /// Event that runs when the form is loaded
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void frmEmployeeManagement_Load(object sender, EventArgs e)
       {
           if (AuxEmployee != null)
           {
               // We recover the data of selected employee
               this.txtNif.Text = this.AuxEmployee.nif;
               this.txtName.Text = this.AuxEmployee.name;
               this.txtSurname.Text = this.AuxEmployee.surname;
               this.txtPhone.Text = this.AuxEmployee.phone;
               this.txtEmail.Text = this.AuxEmployee.email;
               this.txtAdress.Text = this.AuxEmployee.adress;

               this.btnCreate.Enabled = false; // We disable the button to create a task
               this.txtNif.Enabled = false;
               this.btnUpdateEmployee.Enabled = true;
               this.btnDeleteEmployee.Enabled = true;
           }
           else
           {
               this.btnCreate.Enabled = true;
               this.txtNif.Enabled = true;
               this.btnUpdateEmployee.Enabled = false;
               this.btnDeleteEmployee.Enabled = false;
           }

           ///Sets the tooltips for the view
           ///Nota: Interesante poner las restricciones de la base de datos directamente.
           ToolTip ToolTips = new ToolTip();
           //ToolTip1.IsBalloon = true;
           ToolTips.SetToolTip(this.lblNif, "Nif employee.");
       }
       */

    }

}
