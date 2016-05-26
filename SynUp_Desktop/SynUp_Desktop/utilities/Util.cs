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

            if (!existant) pForm.Controls.Add(menu);

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


            formCommonConfiguration(pForm);
            
        }

        public static void dgvCommonConfiguration(DataGridView pDataGrid)
        {
            // DatagridView Common Configuration             
            pDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            pDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row      
            pDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pDataGrid.AllowUserToAddRows = false; // Can't add rows
            pDataGrid.AllowUserToDeleteRows = false; // Can't delete rows
            pDataGrid.AllowUserToOrderColumns = false; //Can't order columns
            pDataGrid.AllowUserToResizeRows = false; //Can't resize columns
            pDataGrid.Cursor = Cursors.Hand; // Cursor hand type            
            pDataGrid.MultiSelect = false; //Can't multiselect
            pDataGrid.RowTemplate.ReadOnly = true;
            pDataGrid.RowHeadersVisible = false; // We hide the rowheader
            pDataGrid.AutoResizeColumns(); //Autoresize columns

        }

        public static void formCommonConfiguration(Form pForm)
        {
            //Form Common Configurations
            pForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            pForm.MinimizeBox = false;
            pForm.MaximizeBox = false;
            pForm.BackColor = System.Drawing.SystemColors.InactiveCaption; //Change backColor of form
        }

        /// <summary>
        /// Event of click on the menu's options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void childClick(object sender, EventArgs e)
        {
            try
            {
                if (sender.ToString().Equals("Main"))
                {
                    controllerSender.MainView.ShowDialog();
                }
                else if (sender.ToString().Equals("Employees"))
                {
                    controllerSender.EmployeeView.ShowDialog();
                }
                else if (sender.ToString().Equals("Teams"))
                {
                    controllerSender.TeamsView.ShowDialog();
                }
                else if (sender.ToString().Equals("Tasks"))
                {
                    controllerSender.TasksView.ShowDialog();
                }
                else if (sender.ToString().Equals("Statistics"))
                {
                    controllerSender.StatisticsView.ShowDialog();
                }
                else if (sender.ToString().Equals("About"))
                {
                    controllerSender.AboutView.ShowDialog();
                }
                else if (sender.ToString().Equals("Exit"))
                {
                    if (clMessageBox.confirmationDialog(Literal.CONFIRMATION_EXIT, "SynUp")) Application.Exit();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("This view is already opened.");
            }
        }
    }
}
