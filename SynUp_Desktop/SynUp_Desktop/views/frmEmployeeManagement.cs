﻿using SynUp_Desktop.controller;
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
    /// <summary>
    /// Form of employee management
    /// </summary>
    public partial class frmEmployeeManagement : Form
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

        private Boolean _blHelp = false;
        private int maxHeight;
        private int minHeight;
        public Employee AuxEmployee;

        public frmEmployeeManagement()
        {
            InitializeComponent();
            maxHeight = this.MaximumSize.Height;
            minHeight = this.MinimumSize.Height;
        }

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

            Boolean _blCreateOk;

            if (this.validateFields())
            {
                _blCreateOk = this.Controller.EmployeeService.createEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress);

                /// MODIFICATION - Pablo, 170516, clMessageBox made static to access the methods without having to create an object of the class.
                if (_blCreateOk)
                {
                    clMessageBox.showMessage(Literal.CREATE_EMPLOYEE_CORRETLY, _blCreateOk, this);
                    this.btnClear_Click(sender, e);
                    this.Close();
                }
                else
                {
                    clMessageBox.showMessage(Literal.CREATE_EMPLOYEE_FAILED, _blCreateOk, this);
                }
            }
            else if (txtNif.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                this.HelpMessage(Literal.ERROR_VALIDATION_EMPLOYEE, (int)utilities.Help.HelpIcon.ERROR);
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
            String _strUsername = txtEmail.Text;

            if (!txtEmail.Text.Equals(""))
            {
                if (this.checkEmail())
                {
                    if (clMessageBox.confirmationDialog(Literal.CONFIRMATION_UPDATE_EMPLOYEE, this.Text))
                    {
                        Boolean _blUpdateOk = this.Controller.EmployeeService.updateEmployee(_strNif, _strName, _strSurname, _strPhone, _strEmail, _strAdress, _strUsername);

                        if (_blUpdateOk)
                        {
                            clMessageBox.showMessage(Literal.UPDATE_EMPLOYEE_CORRETLY, true, this);
                            this.btnClear_Click(sender, e);
                            this.Close();
                        }
                        else
                        {
                            clMessageBox.showMessage(Literal.UPDATE_EMPLOYEE_FAILED, false, this);
                        }
                    }
                }
            }
            else this.HelpMessage(Literal.ERROR_VALIDATION_EMPLOYEE, (int)utilities.Help.HelpIcon.ERROR); //Pablo Ardèvol 22/05 1552, Método pulido.             

        }

        /// <summary>
        /// Event that runs when the button is clicked to delete a employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oDeleteEmployee = null;

            if (clMessageBox.confirmationDialog(Literal.CONFIRMATION_DELETE_EMPLOYEE, this.Text))
            {
                _oDeleteEmployee = this.Controller.EmployeeService.deleteEmployee(AuxEmployee);
                if (_oDeleteEmployee != null)
                {
                    clMessageBox.showMessage(Literal.DELETE_EMPLOYEE_CORRETLY, true, this);
                    this.btnClear_Click(sender, e);
                    this.Close();
                }
                else
                {
                    clMessageBox.showMessage(Literal.DELETE_EMPLOYEE_FAILED, false, this);
                }
            }
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
            this.checkDNI();

            #region //DELETE:Cristina C. 20/05/2016 Move to private method
            /*
            if (AuxEmployee == null)
            {
                string _strNif = "";
                if (txtNif.Text != null) _strNif = txtNif.Text;

                Employee _oEmployee = Controller.EmployeeService.readEmployee(_strNif); // We look for if the employee already exists

                if (_oEmployee != null || !Regex.Match(_strNif, _strNifExpression).Success) // If the employee exists, we show a message
                {
                    lblNif.ForeColor = Color.Red;
                }
                else if (txtNif.Text == "" || txtEmail.Text == "")
                {
                    this.btnHelp_MouseClick(this, null);
                }
                else
                {
                    lblNif.ForeColor = Color.Black;
                }
            }*/
            #endregion
        }

        /// <summary>
        /// Event that runs when the text of email is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.checkEmail();

            #region //DELETE:Cristina C. 20/05/2016 Move to private method
            /*Boolean _blCorrect = false;
            string _strEmail = "";

            if (txtEmail.Text != "")
            {
                String _strEmailExpression = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
                _strEmail = txtEmail.Text;

                if (!Regex.Match(_strEmail, _strEmailExpression).Success) // If the team exists, we show a message
                {
                    lblEmail.ForeColor = Color.Red;
                    _blCorrect = false;
                }
                else
                {
                    lblEmail.ForeColor = Color.Black;
                    _blCorrect = true;
                }
            }*/
            #endregion
        }

        /// <summary>
        /// Method that validartes fields
        /// </summary>
        /// <returns></returns>
        private bool validateFields()
        {
            Boolean _blCorrect = false;
            Boolean _blNif = false, _blEmail = false;

            _blNif = this.checkDNI();

            _blEmail = this.checkEmail();

            if (checkDNI() && checkEmail())
            {
                _blCorrect = true;
            }
            else
            {
                this.HelpMessage(Literal.ERROR_VALIDATION_EMPLOYEE, (int)utilities.Help.HelpIcon.WARNING);
            }

            return _blCorrect;

        }

        /// <summary>
        /// Method that checks if the dni is correct
        /// </summary>
        /// <returns></returns>
        private Boolean checkDNI()
        {
            Boolean _blNif = false;
            if (AuxEmployee == null) //Si el empleado auxiliar es null, comprobamos las expresiones de DNI i correo
            {
                string _strNif = "";

                if (txtNif.Text != "")
                {
                    String _strNifExpression = "^\\d{8}[a-zA-Z]$";
                    _strNif = txtNif.Text;
                    Employee _oEmployee = Controller.EmployeeService.readEmployee(_strNif); // We look for if the employee already exists

                    if (_oEmployee != null || !Regex.Match(_strNif, _strNifExpression).Success) // If the employee exists, we show a message
                    {
                        lblNif.ForeColor = Color.Red;
                        _blNif = false;
                    }
                    else
                    {
                        lblNif.ForeColor = Color.Black;
                        _blNif = true;
                    }
                }

            }
            return _blNif;
        }

        /// <summary>
        /// Method that checks if the email is correct
        /// </summary>
        /// <returns></returns>
        private Boolean checkEmail()
        {
            Boolean _blEmail = false;
            string _strEmail = "";

            //if (txtEmail.Text != "")
            //{
            String _strEmailExpression = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            _strEmail = txtEmail.Text;

            if (!Regex.Match(_strEmail, _strEmailExpression).Success) // If the team exists, we show a message
            {
                lblEmail.ForeColor = Color.Red;
                _blEmail = false;
            }
            else
            {
                lblEmail.ForeColor = Color.Black;
                _blEmail = true;
            }
            //}

            return _blEmail;
        }

        #endregion

        #region FORM EVENTS

        /// <summary>
        /// Event that runs when the forms loaded
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
                this.txtUsername.Text = this.AuxEmployee.username;

                this.enabledCreate(false);// We disable the button to create a task
            }
            else
            {
                this.btnClear_Click(sender, e);
            }

            this.setToolTips(); //Sets the tooltips for the view

            this._blHelp = false;
            utilities.Help.walkingControls(this, this.messageHelps_MouseHover, this.messageHelps_MouseLeave);

            Util.loadMenu(this, this.controller);
        }

        /// <summary>
        /// Event that runs when the button clear is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearForm();
            _blHelp = utilities.Help.hideShowHelp(true, this, minHeight, maxHeight);
        }

        /// <summary>
        /// Event that runs when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.btnClear_Click(sender, e);
        }

        #endregion

        /// <summary>
        /// Method that sets the tooltips for the view
        /// </summary>
        private void setToolTips()
        {
            ///Nota: Interesante poner las restricciones de la base de datos directamente.
            ToolTip ToolTips = new ToolTip();
            //ToolTip1.IsBalloon = true;
            ToolTips.SetToolTip(this.lblNif, "[00000000A]");
            ToolTips.SetToolTip(this.lblPhone, "[000000000]");
            ToolTips.SetToolTip(this.lblEmail, "[exemple@domain.com]");

        }

        /// <summary>
        /// Method that clears form
        /// </summary>
        private void clearForm()
        {
            this.btnClear.clearFields();
            this.AuxEmployee = null;
            this.enabledCreate(true);
        }

        /// <summary>
        /// MEthod that enableds create or update/delete
        /// </summary>
        /// <param name="pEnabled">True for enabled create</param>
        private void enabledCreate(Boolean pEnabled)
        {
            if (pEnabled)
            {
                this.txtNif.Enabled = true;
                this.btnCreate.Enabled = true;
                this.btnUpdateEmployee.Enabled = false;
                this.btnDeleteEmployee.Enabled = false;
            }
            else
            {
                this.txtNif.Enabled = false;
                this.btnCreate.Enabled = false;
                this.btnUpdateEmployee.Enabled = true;
                this.btnDeleteEmployee.Enabled = true;
            }

        }

        #region HELP        

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {
            _blHelp = utilities.Help.hideShowHelp(_blHelp, this, minHeight, maxHeight);
            if (_blHelp) this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
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
                this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
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
                int _info = (int)utilities.Help.HelpIcon.INFORMATION;

                if (sender.Equals(lblNif) || sender.Equals(txtNif))
                {
                    this.HelpMessage(Literal.INFO_NIF_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Documento nacional de identidad. No puede estar vacío y tiene que ser válido."
                    //    + "En caso de tener que cambiar el DNI contacte con el administrador de la base de datos.";
                }
                else if (sender.Equals(lblName) || sender.Equals(txtName))
                {
                    this.HelpMessage(Literal.INFO_NAME_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Nombre del trabajador.";
                }
                else if (sender.Equals(lblSurname) || sender.Equals(txtSurname))
                {
                    this.HelpMessage(Literal.INFO_SURNAME_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Apellidos del trabajador.";
                }
                else if (sender.Equals(lblPhone) || sender.Equals(txtPhone))
                {
                    this.HelpMessage(Literal.INFO_PHONE_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Número de contacto del trabajador.";
                }
                else if (sender.Equals(lblEmail) || sender.Equals(txtEmail))
                {
                    this.HelpMessage(Literal.INFO_EMAIL_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Correo electrónico del trabajador. Se utilizará como nombre de usuario en el aplicación mobil";
                }
                else if (sender.Equals(lblAdress) || sender.Equals(txtAdress))
                {
                    this.HelpMessage(Literal.INFO_ADRESS_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Dirección postal del trabajador.";
                }
                else if (sender.Equals(lblUsername) || sender.Equals(txtUsername))
                {
                    this.HelpMessage(Literal.INFO_USERNAME_EMPLOYEE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Nombre de usuario que utiliza en la aplicación. Solamente puede ser modificado por el propio trabajador desde la app.";
                }
                else if (sender.Equals(btnCreate))
                {
                    this.HelpMessage(Literal.INFO_BTN_CREATE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Clicke aquí para crear un nuevo trabajador.";
                }
                else if (sender.Equals(btnUpdateEmployee))
                {
                    this.HelpMessage(Literal.INFO_BTN_UPDATE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Clicke aquí para modificar los datos del trabajador.";
                }
                else if (sender.Equals(btnDeleteEmployee))
                {
                    this.HelpMessage(Literal.INFO_BTN_DELETE, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Clicke aquí para para eliminar el trabajador.";
                }
                else if (sender.Equals(btnClear))
                {
                    this.HelpMessage(Literal.INFO_BTN_CLEAR, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Clicke aquí para limpiar los valores del formulario.";
                }
                else if (sender.Equals(btnBack))
                {
                    this.HelpMessage(Literal.INFO_BTN_BACK, _info);
                    //this.changeIconMessage(3);
                    //this.lblHelpMessage.Text = "Clicke aquí para volver al menú principal.";
                }
            }
        }

        /// <summary>
        /// Method that shows message help
        /// </summary>
        private void HelpMessage(String pMessage, int pIcon)
        {
            this.Height = maxHeight;
            this.pbxIconMessage.Image = utilities.Help.changeIconMessage(pIcon);
            this.lblHelpMessage.Text = pMessage;
        }

        #endregion

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

/* DELETE: Cristina C. 19/05/2016 - Lo hemos cambiado por un usercontrol
     * /// <summary>
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
        foreach (Control _control in this.Controls) //Recorremos los componentes del formulario
        {
            if (_control is GroupBox)
            {
                foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                {
                    if (_inGroupBox is TextBox)
                    {
                        _inGroupBox.Text = "";
                    }
                }
            }
        }
    }
    */

/* DEPRECATED METHOD - Moved to the formLoad

    /// <summary>
/// Event that runs when the forms activated
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

 * private void frmEmployeeManagement_Activated(object sender, EventArgs e)
{
    //if (AuxEmployee != null)
    //{
    //    // We recover the data of selected employee
    //    this.txtNif.Text = this.AuxEmployee.nif;
    //    this.txtName.Text = this.AuxEmployee.name;
    //    this.txtSurname.Text = this.AuxEmployee.surname;
    //    this.txtPhone.Text = this.AuxEmployee.phone;
    //    this.txtEmail.Text = this.AuxEmployee.email;
    //    this.txtAdress.Text = this.AuxEmployee.adress;
    //    this.txtUsername.Text = this.AuxEmployee.username;

    //    this.btnCreate.Enabled = false; // We disable the button to create a task
    //    this.txtNif.Enabled = false;
    //    this.btnUpdateEmployee.Enabled = true;
    //    this.btnDeleteEmployee.Enabled = true;
    //}
    //else
    //{
    //    this.btnCreate.Enabled = true;
    //    this.txtNif.Enabled = true;
    //    this.btnUpdateEmployee.Enabled = false;
    //    this.btnDeleteEmployee.Enabled = false;
    //    //this.clearValues();
    //}

    //this.setToolTips(); //Sets the tooltips for the view
    //this._blHelp = false;
}*/

/* DELETE: Pablo Ardèvol 230516 - Se mueve a la classe utilities.Help

/// <summary>
    /// Method that changes the icon message
    /// </summary>
    /// <param name="pIcon"></param>
    private void changeIconMessage(int pIcon)
    {
        String _strFilename = null;
        Bitmap _image = null;

        if (pIcon == (int)HelpIcon.WARNING)
        {
            _strFilename = Application.StartupPath + Literal.WARNING_ICON;
        }
        else if (pIcon == (int)HelpIcon.ERROR)
        {
            _strFilename = Application.StartupPath + Literal.ERROR_ICON;
        }
        else if (pIcon == (int)HelpIcon.INFORMATION)
        {
            _strFilename = Application.StartupPath + Literal.INFORMATION_ICON;
        }

        //Configurates de icon message
        if (_strFilename != null)
        {
            _image = new Bitmap(_strFilename);
        }

        this.pbxIconMessage.Image = _image;

    }

*/

/*DEPRECATED METHOD. - Moved to the generic button
   /// <summary>
   /// Method that cleans values
   /// </summary>        
   private void clearValues() 
   {
       this.btnCreate.Enabled = true;
       this.btnUpdateEmployee.Enabled = false;
       this.btnDeleteEmployee.Enabled = false;
       this.txtNif.Enabled = true;
       /*foreach (Control _control in this.Controls) //Recorremos los componentes del formulario
       {
           if (_control is GroupBox)
           {
               foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
               {
                   if (_inGroupBox is TextBox)
                   {
                       _inGroupBox.Text = "";

                   }
                   if (_inGroupBox is Label)
                   {
                       _inGroupBox.ForeColor = Color.Black;
                   }
               }
           }
       }
   }*/

/* DELETE: 270516 Cristina C. Move to Help class
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
*/
