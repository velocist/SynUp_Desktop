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
    /// Controller class that handles the views and the _TaskService that will acccess the object of data access. 
    /// </summary>
    /// <Author>Cristina Caballero</Author>
    ///<Version>0.01</Version>
    ///<Date>03/05/2016_1819</Date>
    public class Controller
    {

        #region VARIABLES
        private TaskService _TaskService;
        private TeamService _TeamService;
        private EmployeeService _EmployeeService;
        private TeamHistoryService _TeamHistoryService;
        private StatisticsService _StatisticsService;

        private frmAbout _AboutView;
        private frmStatistics _StatisticsView;
        private frmTasks _TasksView;
        private frmTeams _TeamsView;
        private frmEmployeeManagement _EmployeeMgtView;
        private frmEmployees _EmployeeView;
        private frmMain _MainView;
        private frmTaskManagement _TaskMgtView;
        private frmTeamManagement _TeamMgtView;
        #endregion

        #region GETTERS AND SETTERS
        public TaskService TaskService
        {
            get
            {
                return _TaskService;
            }

            set
            {
                _TaskService = value;
            }
        }

        public TeamService TeamService
        {
            get
            {
                return _TeamService;
            }

            set
            {
                _TeamService = value;
            }
        }

        public EmployeeService EmployeeService
        {
            get
            {
                return _EmployeeService;
            }

            set
            {
                _EmployeeService = value;
            }
        }

        public TeamHistoryService TeamHistoryService
        {
            get
            {
                return _TeamHistoryService;
            }

            set
            {
                _TeamHistoryService = value;
            }
        }

        public frmAbout AboutView
        {
            get
            {
                return _AboutView;
            }

            set
            {
                _AboutView = value;
            }
        }

        public frmStatistics StatisticsView
        {
            get
            {
                return _StatisticsView;
            }

            set
            {
                _StatisticsView = value;
            }
        }

        public frmTasks TasksView
        {
            get
            {
                return _TasksView;
            }

            set
            {
                _TasksView = value;
            }
        }

        public frmTeams TeamsView
        {
            get
            {
                return _TeamsView;
            }

            set
            {
                _TeamsView = value;
            }
        }

        public frmEmployeeManagement EmployeeMgtView
        {
            get
            {
                return _EmployeeMgtView;
            }

            set
            {
                _EmployeeMgtView = value;
            }
        }

        public frmEmployees EmployeeView
        {
            get
            {
                return _EmployeeView;
            }

            set
            {
                _EmployeeView = value;
            }
        }

        public frmMain MainView
        {
            get
            {
                return _MainView;
            }

            set
            {
                _MainView = value;
            }
        }

        public frmTaskManagement TaskMgtView
        {
            get
            {
                return _TaskMgtView;
            }

            set
            {
                _TaskMgtView = value;
            }
        }

        public frmTeamManagement TeamMgtView
        {
            get
            {
                return _TeamMgtView;
            }

            set
            {
                _TeamMgtView = value;
            }
        }

        internal StatisticsService StatisticsService
        {
            get
            {
                return _StatisticsService;
            }

            set
            {
                _StatisticsService = value;
            }
        }

        #endregion

    }
}
