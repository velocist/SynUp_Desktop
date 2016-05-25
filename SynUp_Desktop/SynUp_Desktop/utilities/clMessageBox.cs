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
        
        /// <summary>
        /// Method that shows a message action
        /// </summary>
        /// <param name="pAction">The action that was realized Values:[created,deleted,updated,added,deleted,assigned,unassigned]</param>
        /// <param name="pObject">The object</param>
        /// <param name="pCorrect">If the action was correctly or wrong</param>
        /// <param name="pNameForm">The name of form which send the action</param>
        public static void showMessageAction(String pMessage, Boolean pCorrect, Form pForm)
        {
            //public static void showMessageAction(ACTIONTYPE pAction, String pObject, Boolean pCorrect, Form pForm)
            //Nombre del método cambiado a showMessageAction para hacerlo más "userfriendly"
            //String _strMessage = null;
            MessageBoxIcon _iconMessageBox;

            //    String _strAction = actionToString(pAction, pCorrect);
            if (pCorrect)
            {
                //_strMessage = "The " + pObject + _strAction;
                _iconMessageBox = MessageBoxIcon.Information;
                //pForm.Close();

            }
            else
            {
                //_strMessage = "The " + pObject + _strAction;
                _iconMessageBox = MessageBoxIcon.Error;
            }

            MessageBox.Show(pForm, pMessage, pForm.Text, MessageBoxButtons.OK, _iconMessageBox);

        }

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
        /// Method that shows a message
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        //private static String messageToString(MESSAGE pMessage, String pObject)
        //{
        //    String _strMessage = null;
        //    String _strInitialMessage = "This " + pObject;
        //    switch (pMessage.ToString())
        //    {
        //        case "EXIST":
        //            _strMessage = _strInitialMessage + " already exists";
        //            break;
        //        case "INTEAM":
        //            _strMessage = _strInitialMessage + " already on the team";
        //            break;
        //        case "WRONG":
        //            _strMessage = "\tWrong fields.\nInsert again the values.";
        //            break;

        //    }
        //    return _strMessage;
        //}

    }
}
