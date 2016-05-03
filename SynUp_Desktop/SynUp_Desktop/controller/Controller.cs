using SynUp_Desktop.service;
using SynUp_Desktop.views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.controller
{
    /// <summary>
    /// Controller class that handles the views and the service that will acccess the object of data access. 
    /// </summary>
    /// <Author>Cristina Caballero</Author>
    ///<Version>0.01</Version>
    ///<Date>03/05/2016_1819</Date>
    public class Controller
    {

        private static Service service;
        private static frmAbout AboutView; 
        private static frmStadistics StatisticsView;
        private static frmTasks TasksView;
        private static frmTeams TeamsView;
        private static frmEmployeeManagement EmployeeMgtView;
        private static frmEmployees EmployeeView;
        private static frmMain MainView;
        private static frmTaskManagement TaskMgtView;
        private static frmTeamManagement TeamMgtView;


        #region GETTERS AND SETTERS
        public static frmAbout AboutView1
        {
            get
            {
                return AboutView;
            }

            set
            {
                AboutView = value;
            }
        }

        public static frmStadistics StatisticsView1
        {
            get
            {
                return StatisticsView;
            }

            set
            {
                StatisticsView = value;
            }
        }

        public static frmTasks TasksView1
        {
            get
            {
                return TasksView;
            }

            set
            {
                TasksView = value;
            }
        }

        public static frmTeams TeamsView1
        {
            get
            {
                return TeamsView;
            }

            set
            {
                TeamsView = value;
            }
        }

        public static frmEmployeeManagement EmployeeMgtView1
        {
            get
            {
                return EmployeeMgtView;
            }

            set
            {
                EmployeeMgtView = value;
            }
        }

        public static frmEmployees EmployeeView1
        {
            get
            {
                return EmployeeView;
            }

            set
            {
                EmployeeView = value;
            }
        }

        public static frmMain MainView1
        {
            get
            {
                return MainView;
            }

            set
            {
                MainView = value;
            }
        }

        public static frmTaskManagement TaskMgtView1
        {
            get
            {
                return TaskMgtView;
            }

            set
            {
                TaskMgtView = value;
            }
        }

        public static frmTeamManagement TeamMgtView1
        {
            get
            {
                return TeamMgtView;
            }

            set
            {
                TeamMgtView = value;
            }
        }

        public static Service Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }
        #endregion

    }
}
