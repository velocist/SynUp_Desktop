using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
    public static class clMessageBox
    {
        //realmente necesitamos el atributo?
        /*private static MessageBox msgBox;

        public static MessageBox MsgBox
        {
            get { return msgBox; }
            set { msgBox = value; }
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAction">The action that was realized</param>
        /// <param name="pObject">The object</param>
        /// <param name="pCorrect">If the action was correctly or wrong</param>
        /// <param name="pNameForm">The name of form which send the action</param>
        public static void showMessage(String pAction, String pObject, Boolean pCorrect, Form pForm)
        {
            //Nombre del método cambiado a showMessage para hacerlo más "userfriendly"
            String _strMessage = null;
            MessageBoxIcon _iconMessageBox;

            if (pCorrect)
            {
                _strMessage = "The " + pObject + " was " + pAction + " succesfully";
                _iconMessageBox = MessageBoxIcon.Information;
                pForm.Close();
                
            }
            else
            {
                _strMessage = "The " + pObject + " wasn't " + pAction + " succesfully";
                _iconMessageBox = MessageBoxIcon.Error;
            }

            MessageBox.Show(_strMessage, pForm.Text, MessageBoxButtons.OK, _iconMessageBox);
        }


        private static void configureMessageBox(MessageBox pMessageBox)
        {


        }
    }
}
