using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
    /// <summary>
    /// Class Message Box 
    /// </summary>
    public static class clMessageBox
    {

        /// <summary>
        /// Method that shows the message help
        /// </summary>
        /// <param name="pMessage"></param>
        /// <param name="pCorrect"></param>
        /// <param name="pForm"></param>
        public static void showMessage(String pMessage, Boolean pCorrect, Form pForm)
        {
            MessageBoxIcon _iconMessageBox;

            if (pCorrect)
            {
                _iconMessageBox = MessageBoxIcon.Information;
            }
            else
            {
                _iconMessageBox = MessageBoxIcon.Error;
            }

            MessageBox.Show(pForm, pMessage, pForm.Text, MessageBoxButtons.OK, _iconMessageBox);
        }

        /// <summary>
        /// Confirmation dialog that will let the user confirm they action or cancel it.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Button click</returns>
        public static bool confirmationDialog(string message, string titleForm)
        {
            return (MessageBox.Show(message, titleForm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

    }
}
