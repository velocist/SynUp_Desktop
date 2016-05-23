using System;
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
        public static bool hideShowHelp(bool _blHelp, Form _FrParent)
        {
            if (_blHelp)
            {
                _FrParent.Height = 290;
                //_FrParent.HelpMessage("", (int)HelpIcon.WARNING);
                //this.changeIconMessage(0);
                //this.lblHelpMessage.Text = "";
                //_FrParent.walkingControls();
            }
            else
            {
                _FrParent.Height = 360;
                //_FrParent.walkingControls();
            }

            return !_blHelp; //It will return the opposite of the value received
        }        
    }
}
