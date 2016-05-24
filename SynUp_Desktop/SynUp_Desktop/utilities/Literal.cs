﻿using System;
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
        public static readonly string ERROR_EXISTENT_EMPLOYEE = "This Employee already exists. Try with another NIF";
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

        public static readonly string INFO_CODE_TASK = "Code identity of the task. There can't be two tasks with the same code. It can't be null.";
        public static readonly string INFO_NAME_TASK = "Name of the task. It can't be null.";
        public static readonly string INFO_LOCATION_TASK = "Location where the task is going to be done.";
        public static readonly string INFO_PROJECT_TASK = "Project that the task belongs to.";
        public static readonly string INFO_DATE_TASK = "Priority date. The task should be finished before.";
        public static readonly string INFO_DESC_TASK = "Description of the task.";
        public static readonly string INFO_STATE_TASK = "State of the task. It will be changed in from the mobile device.";
        public static readonly string INFO_IMPORTANCE_TASK = "Priority of the task.";
        public static readonly string INFO_IDTEAM_TASK = "The team the task is assigned to.";

        public static readonly string INFO_CODE_TEAM = "Code identity of the team. There can't be two teams with the same code. It can't be null.";
        public static readonly string INFO_NAME_TEAM = "Name of the team.";
        public static readonly string INFO_ADD_TEAM = "Add an employee to the team.";
        public static readonly string INFO_DELETE_TEAM = "Deletes the selected employee from the team.";

        public static readonly string INFO_RESULTS_STATISTICS = "Results of the search.";
        public static readonly string INFO_FILTER_STATISTICS = "Select the filter you want to use for the search.";
        public static readonly string INFO_STATE_STATISTICS = "Select the state of the task you want to filter for.";
        public static readonly string INFO_RANKING_STATISTICS = "Select from what entity you want to check the ranking.";
        public static readonly string INFO_DTSTART_STATISTICS = "Select the start date of the period.";
        public static readonly string INFO_DTEND_STATISTICS = "Select the end date of the period. It can't be lesser than the selected Start Date.";

        public static readonly string INFO_BTN_CREATE = "Click here to create it.";
        public static readonly string INFO_BTN_UPDATE = "Click here to update it.";
        public static readonly string INFO_BTN_DELETE = "Click here to delete it.";
        public static readonly string INFO_BTN_CLEAR = "Click here to clear all the values of the form.";
        public static readonly string INFO_BTN_BACK = "Click here to close the form and return to the previous view.";
        public static readonly string INFO_BTN_SEARCH = "Click here to search the values.";

        public static readonly string INFO_BTN_MANAGEMENT = "Click here to view the details and edit the selected row.";

        //public static readonly string CONFIRMATION_CREATE_EMPLOYEE = "Are you sure you want to insert this employee?";
        public static readonly string CONFIRMATION_UPDATE_EMPLOYEE = "Are you sure you want to update this employee?";
        public static readonly string CONFIRMATION_DELETE_EMPLOYEE = "Are you sure you want to delete this employee?";
        public static readonly string CONFIRMATION_UPDATE_TASK = "Are you sure you want to update this task?";
        public static readonly string CONFIRMATION_DELETE_TASK= "Are you sure you want to delete this task?";
        public static readonly string CONFIRMATION_UPDATE_TEAM= "Are you sure you want to update this team?";
        public static readonly string CONFIRMATION_DELETE_TEAM= "Are you sure you want to delete this team?";

        public static readonly string WARNING_DATEDIFF_STATISTICS = "End date must be bigger than the start date.";
        public static readonly string WARNING_UNSELECTED_STATISTICS = "Select a correct item from the expandable list.";
        public static readonly string WARNING_EMPTY_STATISTICS = "No items where retrieved.";
               
            }
}
