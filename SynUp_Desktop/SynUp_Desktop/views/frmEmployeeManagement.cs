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

            Boolean _blCreateOk = this.Controller.EmployeeService.createEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress);

            /*utilities.clMessageBox _msgBox = new utilities.*//// MODIFICATION - Pablo, 170516, clMessageBox made static to access the methods without having to create an object of the class.
            clMessageBox.showMessage(clMessageBox.ACTIONTYPE.CREATE, "employee", _blCreateOk, this);

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

            Boolean _blUpdateOk = this.Controller.EmployeeService.updateEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress, _strUsername);
            clMessageBox.showMessage(clMessageBox.ACTIONTYPE.UPDATE, "employee", _blUpdateOk, this);

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

            clMessageBox.showMessage(clMessageBox.ACTIONTYPE.DELETE, "employee", _blDelete, this);
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

        private Boolean _blHelp = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {
            if (_blHelp)
            {
                _blHelp = false;
                this.Height = 290;
            }
            else
            {
                _blHelp = true;
                this.Height = 360;

                foreach (Control _control in this.Controls) //Recorremos los componentes del formulario
                {
                    if (_control is GroupBox)
                    {
                        foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                        {
                            if (_inGroupBox is TextBox)
                            {
                                _inGroupBox.Enabled = false;
                            }
                            else if (_inGroupBox is Label)
                            {
                                _inGroupBox.ForeColor = Color.Red;
                            }
                            _inGroupBox.MouseHover += new EventHandler(messageHelps_MouseHover);
                        }
                    }
                    else if (_control is Button)
                    {
                        _control.BackColor = Color.Red;
                        _control.MouseHover += new EventHandler(messageHelps_MouseHover);
                    }

                }
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
                if (sender.Equals(lblNif) || sender.Equals(txtNif))
                {
                    this.lblHelpMessage.Text = "Message help label NIF";
                }
                else if (sender.Equals(lblName) || sender.Equals(txtName))
                {
                    this.lblHelpMessage.Text = "Message help label NAME";
                }
                else if (sender.Equals(lblSurname) || sender.Equals(txtSurname))
                {
                    this.lblHelpMessage.Text = "Message help label SURNAME";
                }
                else if (sender.Equals(lblPhone) || sender.Equals(txtPhone))
                {
                    this.lblHelpMessage.Text = "Message help label PHONE";
                }
                else if (sender.Equals(lblEmail) || sender.Equals(txtEmail))
                {
                    this.lblHelpMessage.Text = "Message help label EMAIL";
                }
                else if (sender.Equals(lblUsername) || sender.Equals(txtUsername))
                {
                    this.lblHelpMessage.Text = "Message help label USERNAME";
                }
                else if (sender.Equals(btnCreate))
                {
                    this.lblHelpMessage.Text = "Message help Button";
                }
                else if (sender.Equals(btnUpdateEmployee))
                {
                    this.lblHelpMessage.Text = "Message help Button";
                }
                else if (sender.Equals(btnDeleteEmployee))
                {
                    this.lblHelpMessage.Text = "Message help Button";
                }
                else if (sender.Equals(btnClear))
                {
                    this.lblHelpMessage.Text = "Message help Button";
                }
                else if (sender.Equals(btnBack))
                {
                    this.lblHelpMessage.Text = "Message help Button";
                }

            }
        }
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

