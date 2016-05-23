using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.utilities
{
    public static class Literal
    {
        #region icon paths
        public static readonly string WARNING_ICON = "\\views\\images\\warning.png";
        public static readonly string ERROR_ICON = "\\views\\images\\error.png";
        public static readonly string INFORMATION_ICON = "\\views\\images\\information.png";
        #endregion

        public static readonly string ERROR_VALIDATION_EMPLOYEE = "The NIF and/or the e-mail are empty or are wrong formated. Fill the mandatory fields.";
        public static readonly string ERROR_VALIDATION_TASK = "The Code and/or the Name and/or the Priority date are empty. Fill the mandatory fields.";
        public static readonly string ERROR_VALIDATION_TEAM = "The code can't be empty. Fill the mandatory fields.";

        public static readonly string INFO_NIF_EMPLOYEE =   "'Número Identificación Fiscal' It can't be empty and must be valid. " +
                                                            "To change the NIF contact with the database administrator.";
        public static readonly string INFO_NAME_EMPLOYEE = "Name of the employee.";
        public static readonly string INFO_SURNAME_EMPLOYEE = "Surname of the employee.";
        public static readonly string INFO_PHONE_EMPLOYEE = "Contact phone of the employee.";
        public static readonly string INFO_EMAIL_EMPLOYEE = "Email of the employee.";
        public static readonly string INFO_ADRESS_EMPLOYEE = "Adress of the employee.";
        public static readonly string INFO_USERNAME_EMPLOYEE = "Username of the employee used to perform the LOGIN in the mobile application. It can only be modified from the mobile device.";

        public static readonly string INFO_CODE_TASK = "";
        public static readonly string INFO_NAME_TASK = "";
        public static readonly string INFO_LOCATION_TASK = "";
        public static readonly string INFO_PROJECT_TASK = "";
        public static readonly string INFO_DATE_TASK = "";
        public static readonly string INFO_DESC_TASK = "";
        public static readonly string INFO_STATE_TASK = "";
        public static readonly string INFO_IMPORTANCE_TASK = "";
        public static readonly string INFO_IDTEAM_TASK = "";

        public static readonly string INFO_CODE_TEAM = "";
        public static readonly string INFO_NAME_TEAM = "";
        public static readonly string INFO_ADD_TEAM = "";
        public static readonly string INFO_DELETE_TEAM = "";

        public static readonly string INFO_BTN_CREATE = "Click here to create it.";
        public static readonly string INFO_BTN_UPDATE = "Click here to update it.";
        public static readonly string INFO_BTN_DELETE = "Click here to delete it.";
        public static readonly string INFO_BTN_CLEAR = "Click here to clear all the values of the form.";
        public static readonly string INFO_BTN_BACK = "click here to close the form and return to the previous view.";


        //public static readonly string CONFIRMATION_CREATE_EMPLOYEE = "Are you sure you want to insert this employee?";
        public static readonly string CONFIRMATION_UPDATE_EMPLOYEE = "Are you sure you want to update this employee?";
        public static readonly string CONFIRMATION_DELETE_EMPLOYEE = "Are you sure you want to delete this employee?";
        public static readonly string CONFIRMATION_UPDATE_TASK = "Are you sure you want to update this task?";
        public static readonly string CONFIRMATION_DELETE_TASK= "Are you sure you want to delete this task?";
        public static readonly string CONFIRMATION_UPDATE_TEAM= "Are you sure you want to update this team?";
        public static readonly string CONFIRMATION_DELETE_TEAM= "Are you sure you want to delete this team?";

    }
}
