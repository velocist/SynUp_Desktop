using SynUp_Desktop.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.views
{
    public partial class frmMain : Form
    {
        private Controller controller;

        public Controller Controller
        {
            get
            {
                return controller;
            }

            set
            {
                controller = value;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the tasks view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTasks_Click(object sender, EventArgs e)
        {
            //this.Hide();            
            //this.Controller.TasksView.Show();
            this.Controller.TasksView.ShowDialog(); //Vuelvo a colocarlo que da un problema, teenemos que mirar como hacerlo
        }

        /// <summary>
        /// Opens the employees view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //this.Controller.EmployeeView.Show();
            this.Controller.EmployeeView.ShowDialog();
        }

        /// <summary>
        /// Opens the teams view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeams_Click(object sender, EventArgs e)
        {
            //this.Controller.TeamsView.Show();
            this.Controller.TeamsView.ShowDialog();
        }

        /// <summary>
        /// Opens the stadistics view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStadistics_Click(object sender, EventArgs e)
        {
            //this.Controller.StatisticsView.Show();
            this.Controller.StatisticsView.ShowDialog();
        }

        /// <summary>
        /// Exit application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Opens the about view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            //this.Controller.AboutView.Show();
            this.Controller.AboutView.ShowDialog();
        }
        
    }
}
