using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
    public partial class GenericButton : UserControl
    {

        public String buttonText;
        public bool exit;
        public Form parent;

        /// <summary>
        /// Generic button that depending on its boolean will answer to one kind of action or another.
        /// </summary>
        public GenericButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the button text
        /// </summary>
        [Description("Sets the button text."), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Generic")]
        public string ButtonText
        {
            get
            {
                return btnGeneric.Text;
            }

            set
            {
                btnGeneric.Text = value;
            }
        }

        /// <summary>
        /// Determines the functionality of the button.
        /// </summary>
        [Description("Is the button an exit or a clear one."), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Generic")]
        public bool isExit
        {
            get
            {
                return exit;
            }

            set
            {
                exit = value;
            }
        }

        /// <summary>
        /// Determines the parent form of the button.
        /// </summary>
        [Description("Sets the parent Form for the control."), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Generic")]
        public Form Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        public new event EventHandler MouseHover
        {
            add
            {
                base.MouseHover += value;
                foreach (Control control in Controls)
                {
                    control.MouseHover += value;
                }
            }
            remove
            {
                base.MouseHover -= value;
                foreach (Control control in Controls)
                {
                    control.MouseHover -= value;
                }
            }
        }

        public new event EventHandler MouseLeave
        {
            add
            {
                base.MouseLeave += value;
                foreach (Control control in Controls)
                {
                    control.MouseLeave += value;
                }
            }
            remove
            {
                base.MouseLeave -= value;
                foreach (Control control in Controls)
                {
                    control.MouseLeave -= value;
                }
            }
        }

        /// <summary>
        /// If the button isExit, the parent form will close. If it is false, it means it is a clear button and therefore will empty all the textbox fields in the parent form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneric_Click(object sender, EventArgs e)
        {
            if (isExit)
            {
                if (Parent.Modal) //Para los management
                {
                    Parent.Close();
                }
                else //Para las listas*/
                {
                    Parent.Hide();
                }
                //Parent.Close();
            }

            clearFields();
        }

        /// <summary>
        /// Event that runs when the mouse hover the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneric_MouseHover(object sender, EventArgs e)
        {
            if (isExit)
            {
                foreach (Control _control in Parent.Controls)
                {
                    if (_control is GroupBox && _control.Name.Equals("gbHelp"))
                    {
                        foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                        {
                            if (_inGroupBox is Label)
                            {
                                _inGroupBox.Text = Literal.INFO_BTN_BACK;
                            }
                            if (_inGroupBox is PictureBox)
                            {
                                ((System.Windows.Forms.PictureBox)_inGroupBox).Image = new Bitmap(Help.changeIconMessage(2));
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Control _control in Parent.Controls)
                {
                    if (_control is GroupBox && _control.Name.Equals("gbHelp"))
                    {
                        foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                        {
                            if (_inGroupBox is Label)
                            {
                                _inGroupBox.Text = Literal.INFO_BTN_CLEAR;
                            }
                            if (_inGroupBox is PictureBox)
                            {
                                ((System.Windows.Forms.PictureBox)_inGroupBox).Image = new Bitmap(Help.changeIconMessage(2));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Event that runs when the mouse leave the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneric_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control _control in Parent.Controls)
            {
                if (_control is GroupBox && _control.Name.Equals("gbHelp"))
                {
                    foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                    {
                        if (_inGroupBox is Label) //Label lblHelpMessage
                        {
                            _inGroupBox.Text = "";
                        }
                        if (_inGroupBox is PictureBox)
                        {
                            ((System.Windows.Forms.PictureBox)_inGroupBox).Image = new Bitmap(Help.changeIconMessage(2));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Clears all the fields of the form.
        /// </summary>
        public void clearFields()
        {
            foreach (Control _control in Parent.Controls) //Recorremos los componentes del formulario
            {
                if (_control is GroupBox)
                {
                    foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                    {
                        if (_inGroupBox is TextBox) //If the control is a textbox
                        {
                            if (!_inGroupBox.Enabled) _inGroupBox.Enabled = true; //if it is a disabled control
                            _inGroupBox.Text = ""; //sets the text empty
                        }
                        if (_inGroupBox is Label) //If the control is a label
                        {
                            _inGroupBox.ForeColor = Color.Black; //Will reset it's validation changed color.
                        }
                        if (_inGroupBox is DataGridView) //If the control is a Datagridview 
                        {
                            ((System.Windows.Forms.DataGridView)_inGroupBox).DataSource = null; //Will clear datasource  
                            ((System.Windows.Forms.DataGridView)_inGroupBox).Refresh(); //Will refresh datagridview
                        }
                        //if (_inGroupBox is Button) //Boton addtoteam deletetoteam
                        //{
                        //    _inGroupBox.Enabled = false;
                        //}
                    }
                }
                //Nota: Si quitas esto al limpiar el formulario los botones de crear quedan inhabilitados
                // y los de updatear y eliminar quedan habilitados. Nos interesa que haga lo contrario
                if (_control is Button && _control.Name != "btnHelp")
                {
                    if (_control.Name.StartsWith("btnC"))
                    {
                        if (!_control.Enabled) _control.Enabled = true;
                    }

                    if (_control.Name.StartsWith("btnU") || _control.Name.StartsWith("btnD"))
                    {
                        if (_control.Enabled) _control.Enabled = false;
                    }

                }
            }
        }

    }
}
