﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
    /// <summary>
    /// Class refered to the Help sections of the views.
    /// </summary>
    public static class Help
    {
        public enum HelpIcon
        {
            WARNING,
            ERROR,
            INFORMATION,
            NONE
        }

        /// <summary>
        /// Method that changes the icon message
        /// </summary>
        /// <param name="pIcon"></param>
        public static Bitmap changeIconMessage(int pIcon)
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
            else if (pIcon == (int)HelpIcon.NONE)
            {
                _strFilename = null;
            }

            //Configurates de icon message
            if (_strFilename != null)
            {
                _image = new Bitmap(_strFilename);
            }

            return _image;

        }

        /// <summary>
        /// Method accessed when the help button is clicked
        /// </summary>
        /// <param name="_blHelp"></param>
        /// <param name="_FrParent"></param>
        public static bool hideShowHelp(bool _blHelp, Form _FrParent, int _minHeight, int _maxHeight)
        {
            if (_blHelp)
            {
                _FrParent.Height = _minHeight;                
            }
            else
            {
                _FrParent.Height = _maxHeight;
            }

            return !_blHelp; //It will return the opposite of the value received
        }

        /// <summary>
        /// Method that walkings all controls in form
        /// </summary>
        /// <param name="pEnabled"></param>
        public static void walkingControls(Form pForm, EventHandler pMouseHover, EventHandler pMouseLeave)
        {
            foreach (Control _control in pForm.Controls) //Recorremos los componentes del formulario
            {
                if (_control is GroupBox)
                {
                    foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                    {
                        _inGroupBox.MouseHover += new EventHandler(pMouseHover);
                        _inGroupBox.MouseLeave += new EventHandler(pMouseLeave);
                    }
                }
                if (_control is Button)
                {
                    _control.MouseHover += new EventHandler(pMouseHover);
                    _control.MouseLeave += new EventHandler(pMouseLeave);
                }
                if (_control is GenericButton)
                {
                    _control.MouseHover += new EventHandler(pMouseHover);
                    _control.MouseLeave += new EventHandler(pMouseLeave);
                }
            }
        }
    }
}
