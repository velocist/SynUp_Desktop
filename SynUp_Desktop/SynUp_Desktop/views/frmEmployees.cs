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
    /// <summary>
    /// Form of list employees
    /// </summary>
    public partial class frmEmployees : Form
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

        public frmEmployees()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that runs when the button is clicked to manage employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagementEmployee_Click(object sender, EventArgs e)
        {
            this.Controller.EmployeeMgtView1.ShowDialog();
        }

        /// <summary>
        /// Event that runs when the button is clicked to add team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            //TODO Mostrar dialogo con combo para elegir equipo, o Mostrar la lista de equipos
        }

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controller.EmployeeView1.Close();
            this.Controller.MainView1.Show();
        }
    }
}
