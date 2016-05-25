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
        //realmente necesitamos el atributo? xD
        /*private static MessageBox msgBox;

        public static MessageBox MsgBox
        {
            get { return msgBox; }
            set { msgBox = value; }
        }*/

        /// <summary>
        /// Enumeration of actions
        /// </summary>
        public enum ACTIONTYPE
        {
            CREATE,
            DELETE,
            UPDATE,
            ADD,
            EXCLUDE,
            ASSIGN,
            UNASSIGN,
        };

        public enum MESSAGE
        {
            EXIST,
            INTEAM,
            WRONG,
        }

        /// <summary>
        /// Methot that returns text action
        /// </summary>
        /// <param name="pActionType"></param>
        /// <returns></returns>
        private static String actionToString(ACTIONTYPE pActionType, Boolean pCorrect)
        {
            String _strAction = null;
            String _strHasBeen;
            String _strSuccesfully = " successfully.";

            if (pCorrect)
            {
                _strHasBeen = " has been ";
            }
            else
            {
                _strHasBeen = " hasn't been ";
            }

            //Un poco chapuza pero efectivo.. =P
            switch (pActionType.ToString())
            {
                case "CREATE":
                    _strAction = _strHasBeen + "created" + _strSuccesfully;
                    break;
                case "UPDATE":
                    _strAction = _strHasBeen + "updated" + _strSuccesfully;
                    break;
                case "DELETE":
                    _strAction = _strHasBeen + "deleted" + _strSuccesfully;
                    break;
                case "ADD":
                    _strAction = _strHasBeen + "added to team" + _strSuccesfully;
                    break;
                case "EXCLUDE":
                    _strAction = _strHasBeen + "delete to team" + _strSuccesfully;
                    break;
                case "ASSIGN":
                    _strAction = _strHasBeen + "assigned" + _strSuccesfully;
                    break;
                case "UNASSIGNED":
                    _strAction = _strHasBeen + "unassigned" + _strSuccesfully;
                    break;
            }

            return _strAction;
        }

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
            //MessageBox.Show(pMessage, pForm, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //String _strMessage = messageToString(pMessage, pObject);
            //MessageBoxIcon _iconMessageBox = MessageBoxIcon.Information;

            //if (pMessage.Equals("WRONG"))
            //{
            //    _iconMessageBox = MessageBoxIcon.Warning;
            //}

        }
        /// <summary>
        /// Method that shows a message
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        private static String messageToString(MESSAGE pMessage, String pObject)
        {
            String _strMessage = null;
            String _strInitialMessage = "This " + pObject;
            switch (pMessage.ToString())
            {
                case "EXIST":
                    _strMessage = _strInitialMessage + " already exists";
                    break;
                case "INTEAM":
                    _strMessage = _strInitialMessage + " already on the team";
                    break;
                case "WRONG":
                    _strMessage = "\tWrong fields.\nInsert again the values.";
                    break;

            }
            return _strMessage;
        }
        private static void configureMessageBox(MessageBox pMessageBox)
        {

        }
    }
}
