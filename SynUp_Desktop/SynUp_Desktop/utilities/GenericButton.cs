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

        /// <summary>
        /// If the button isExit, the parent form will close. If it is false, it means it is a clear button and therefore will empty all the textbox fields in the parent form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneric_Click(object sender, EventArgs e)
        {
            if (isExit) Parent.Close();
            else clearFields();
        }

        private void clearFields()
        {
            foreach (Control _control in Parent.Controls) //Recorremos los componentes del formulario
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
        }
    }
}
