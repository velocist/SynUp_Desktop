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

            //Change backColor of form
            pForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
                if (clMessageBox.confirmationDialog(Literal.CONFIRMATION_EXIT, "SynUp")) Application.Exit();
            }
        }
    }
}
