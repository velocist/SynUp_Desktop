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
            this.Controller.TasksView.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Controller.EmployeeView.ShowDialog();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            this.Controller.TeamsView.ShowDialog();
        }

        private void btnStadistics_Click(object sender, EventArgs e)
        {
            this.Controller.StatisticsView.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Controller.AboutView.ShowDialog();
        }
    }
}
