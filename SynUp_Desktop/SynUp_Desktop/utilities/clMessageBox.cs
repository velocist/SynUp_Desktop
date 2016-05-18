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
            EXIST,
            WRONG
            
        };

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
                case "EXIST":
                    _strAction = "is already exists";
                    break;
                case "WRONG":                    
                    _strAction = "Wrong selected values.";
                    break;

            }

            return _strAction;
        }

        /// <summary>
        /// Method that shows a message
        /// </summary>
        /// <param name="pAction">The action that was realized Values:[created,deleted,updated,added,deleted,assigned,unassigned]</param>
        /// <param name="pObject">The object</param>
        /// <param name="pCorrect">If the action was correctly or wrong</param>
        /// <param name="pNameForm">The name of form which send the action</param>
        public static void showMessage(ACTIONTYPE pAction, String pObject, Boolean pCorrect, Form pForm)
        {
            //Nombre del método cambiado a showMessage para hacerlo más "userfriendly"
            String _strMessage = null;
            MessageBoxIcon _iconMessageBox;

            String _strAction = actionToString(pAction, pCorrect);
            if (pCorrect)
            {
                _strMessage = "The " + pObject + _strAction;
                _iconMessageBox = MessageBoxIcon.Information;
                pForm.Close();

            }
            else
            {
                _strMessage = "The " + pObject + _strAction;
                _iconMessageBox = MessageBoxIcon.Error;
            }

            MessageBox.Show(_strMessage, pForm.Text, MessageBoxButtons.OK, _iconMessageBox);

        }

        private static void configureMessageBox(MessageBox pMessageBox)
        {


        }
    }
}
