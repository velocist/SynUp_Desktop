using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynUp_Desktop.utilities
{
    public static class Util
    {
        private static controller.Controller controllerSender;

        /// <summary>
        /// Confirmation dialog that will let the user confirm they action or cancel it.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Button click</returns>
        public static bool confirmationDialog(string message, string titleForm)
        {
            return (MessageBox.Show(message, titleForm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        /// <summary>
        /// Load the dynamic menu
        /// </summary>
        public static void loadMenu(Form pForm, controller.Controller pController)
        {
            controllerSender = pController;

            //Creem el menú dinàmic
            MenuStrip menu = new MenuStrip();

            bool existant = false;

            foreach (Control c in pForm.Controls)
            {
                if (c is MenuStrip)
                {
                    existant = true;
                    break;
                }
            }

            if(!existant)pForm.Controls.Add(menu);

            menu.BackColor = System.Drawing.Color.AliceBlue;
            menu.LayoutStyle = ToolStripLayoutStyle.Flow;

            //Creem els menus principals 
            ToolStripMenuItem menuItem;

            //Menu principal
            string[] options = new string[] { "Main", "Employees", "Teams", "Tasks", "Statistics", "About", "Exit" };

            foreach (string opcio in options)
            {
                menuItem = new ToolStripMenuItem(opcio, null, childClick);
                menu.Items.Add(menuItem);
            }

            //if (opcio == "Main")
            //{
            //    menuItem = new ToolStripMenuItem(opcio, null);
            //    string[] options1 = new string[] { "Pause", "Reset" };
            //    foreach (string opcio1 in options1)
            //    {
            //        ToolStripMenuItem menuOptions = new ToolStripMenuItem(opcio1, null, childClick);
            //        menuItem.DropDownItems.Add(menuOptions);
            //    }
            //}
            //else if (opcio == "Employees")
            //{
            //    menuItem = new ToolStripMenuItem(opcio, null);
            //    string[] options1 = new string[] { "Music", "Sound" };
            //    foreach (string opcio1 in options1)
            //    {
            //        ToolStripMenuItem menuOptions = new ToolStripMenuItem(opcio1, null);
            //        menuItem.DropDownItems.Add(menuOptions);

            //        string[] subOptions = new string[] { "On", "Off" };
            //        foreach (string subopcio in subOptions)
            //        {
            //            ToolStripMenuItem menuSubOptions;

            //            if (subopcio == "On")
            //            {
            //                menuSubOptions = new ToolStripMenuItem(subopcio, global::Arkanoid.Properties.Resources.audio49, childClick);
            //                //menuItem.Image = global::ArkanoidProject.Properties.Resources.audio49;

            //            }
            //            else
            //            {
            //                menuSubOptions = new ToolStripMenuItem(subopcio, global::Arkanoid.Properties.Resources.mute35, childClick);
            //                //menuItem.Image = global::ArkanoidProject.Properties.Resources.mute35;
            //            }
            //            menuOptions.DropDownItems.Add(menuSubOptions);
            //        }
            //    }
            //}
            //else
            //{
            //    menuItem = new ToolStripMenuItem(opcio, null, childClick);
            //}
            //menu.Items.Add(menuItem);
            //menuItem.BackColor = Color.Red;
            //}
        }

        /// <summary>
        /// Event of click on the menu's options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void childClick(object sender, EventArgs e)
        {

            if (sender.ToString().Equals("Main"))
            {
                controllerSender.MainView.ShowDialog();
                //controllerSender.MainView.BringToFront();
            }
            else if (sender.ToString().Equals("Employees"))
            {
                controllerSender.EmployeeView.ShowDialog();
                //controllerSender.EmployeeView.BringToFront();
            }
            else if (sender.ToString().Equals("Teams"))
            {
                controllerSender.TeamsView.ShowDialog();
                //controllerSender.TeamsView.BringToFront();
            }
            else if (sender.ToString().Equals("Tasks"))
            {
                controllerSender.TasksView.ShowDialog();
                //controllerSender.TasksView.BringToFront();
            }
            else if (sender.ToString().Equals("Statistics"))
            {
                controllerSender.StatisticsView.ShowDialog();
                //controllerSender.StatisticsView.BringToFront();
            }
            else if (sender.ToString().Equals("About"))
            {
                controllerSender.AboutView.ShowDialog();
                //controllerSender.AboutView.BringToFront();
            }
            else if (sender.ToString().Equals("Exit"))
            {
                if (confirmationDialog(Literal.CONFIRMATION_EXIT, "SynUp")) Application.Exit();
            }
        }
    }
}
