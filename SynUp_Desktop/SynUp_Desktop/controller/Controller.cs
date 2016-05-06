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

        #region VARIABLES
        private TaskService service;
        private frmAbout AboutView;
        private frmStatistics StatisticsView;
        private frmTasks TasksView;
        private frmTeams TeamsView;
        private frmEmployeeManagement EmployeeMgtView;
        private frmEmployees EmployeeView;
        private frmMain MainView;
        private frmTaskManagement TaskMgtView;
        private frmTeamManagement TeamMgtView;
        #endregion

        #region GETTERS AND SETTERS
        public frmAbout AboutView1
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

        public frmStatistics StatisticsView1
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

        public frmTasks TasksView1
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

        public frmTeams TeamsView1
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

        public frmEmployeeManagement EmployeeMgtView1
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

        public frmEmployees EmployeeView1
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

        public frmMain MainView1
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

        public frmTaskManagement TaskMgtView1
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

        public frmTeamManagement TeamMgtView1
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

        public TaskService Service
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
