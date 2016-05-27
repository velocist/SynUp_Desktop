using SynUp_Desktop.controller;
using SynUp_Desktop.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.views
{
    /// <summary>
    /// Form of main menu
    /// </summary>
    public partial class frmMain : Form
    {
        #region CONTROLLER

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

        #endregion

        public frmMain()
        {
            InitializeComponent();

            this.linkUserManuall.Links[0].Description = "User's Manual";
            this.linkUserManuall.Links.Add(0, this.linkUserManuall.Text.Length, Application.StartupPath + "\\Resources\\UserManual_v1.pdf");
        }

        /// <summary>
        /// Opens the tasks view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTasks_Click(object sender, EventArgs e)
        {
            this.Controller.TasksView.ShowDialog();
            this.Controller.TasksView.BringToFront();
        }

        /// <summary>
        /// Opens the employees view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Controller.EmployeeView.ShowDialog();
            this.Controller.EmployeeView.BringToFront();
        }

        /// <summary>
        /// Opens the teams view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeams_Click(object sender, EventArgs e)
        {
            this.Controller.TeamsView.ShowDialog();
            this.Controller.TeamsView.BringToFront();
            //this.Controller.TeamsView.ShowDialog();
        }

        /// <summary>
        /// Opens the stadistics view window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStadistics_Click(object sender, EventArgs e)
        {
            this.Controller.StatisticsView.ShowDialog();
            this.Controller.StatisticsView.BringToFront();
            //this.Controller.StatisticsView.ShowDialog();
        }

        /// <summary>
        /// Exit application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (clMessageBox.confirmationDialog(utilities.Literal.CONFIRMATION_EXIT, "SynUp")) Application.Exit();
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

        /// <summary>
        /// Method that runs when the link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkUserManuall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
                Process.Start(sInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "The UserManual file has been lost. Reinstall the program.", "SynUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
