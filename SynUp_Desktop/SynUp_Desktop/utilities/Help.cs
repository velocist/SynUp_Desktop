using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
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
    }
}
