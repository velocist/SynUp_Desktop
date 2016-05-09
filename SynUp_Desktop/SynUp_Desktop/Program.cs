using SynUp_Desktop.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form toRun = init();

            Application.Run(toRun);
        }

        private static Form init()
        {
            controller.Controller controller = new controller.Controller();
            service.TaskService taskservice = new service.TaskService();
            service.TeamService teamservice = new service.TeamService();
            service.EmployeeService employeeService = new service.EmployeeService();

            controller.TaskService = taskservice;
            controller.TeamService = teamservice;
            controller.EmployeeService = employeeService;

            frmAbout aboutView = new frmAbout();
            frmEmployeeManagement employeeMgtView = new frmEmployeeManagement();
            frmEmployees employeeView = new frmEmployees();
            frmMain mainView = new frmMain();
            frmStatistics statisticsView = new frmStatistics();
            frmTaskManagement taskMgtView = new frmTaskManagement();
            frmTasks taskView = new frmTasks();
            frmTeamManagement teamMgtView = new frmTeamManagement();
            frmTeams teamsView = new frmTeams();

            aboutView.Controller = controller;
            employeeMgtView.Controller = controller;
            employeeView.Controller = controller;
            mainView.Controller = controller;
            statisticsView.Controller = controller;
            taskMgtView.Controller = controller;
            taskView.Controller = controller;
            teamMgtView.Controller = controller;
            teamsView.Controller = controller;

            controller.AboutView = aboutView;
            controller.MainView = mainView;
            controller.StatisticsView = statisticsView;
            controller.TaskMgtView = taskMgtView;
            controller.TasksView = taskView;
            controller.TeamMgtView = teamMgtView;
            controller.TeamsView = teamsView;
            controller.EmployeeView = employeeView;
            controller.EmployeeMgtView = employeeMgtView;

            return mainView;
        }
    }
}
