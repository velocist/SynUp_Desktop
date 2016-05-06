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
        /// Opens the tasks window.
        /// <author>Pablo Ardèvol</author>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.TasksView1.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the employee window.
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.EmployeeView1.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the teams window.
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.TeamsView1.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the statistics window.
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStadistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.StatisticsView1.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the about window.
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.AboutView1.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
