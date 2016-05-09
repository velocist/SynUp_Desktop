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
    public partial class frmTeams : Form
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

        public frmTeams()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the management view window of the teams.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagementTeams_Click(object sender, EventArgs e)
        {
            this.Controller.TeamMgtView.ShowDialog();
        }

        /// <summary>
        /// Event that runs when clicked botton back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event that runs when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeams_Load(object sender, EventArgs e)
        {
            fillGridView();

            // DataGridView Configuration
            dgvTeams.Columns[0].Visible = false; // We hide id column

            dgvTeams.Columns[1].HeaderText = "Code"; // We change the column name
            dgvTeams.Columns[2].HeaderText = "Name";

            dgvTeams.AutoResizeColumns();
            dgvTeams.RowHeadersVisible = false; // We hide the rowheader
            dgvTeams.ClearSelection(); // Cleer selection rows
        }
        
        /// <summary>
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        private void fillGridView()
        {
            ///Note: Revisar si se puedes escoger los nombres de las columnas y las que aparecen al hacer el binding.
            /// He ocultado las dos primeras columnas. Lo he hecho de dos maneras para que veas como se puede hacer.

            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();

            dgvTeams.DataSource = source;

            dgvTeams.Refresh();

        }

        private void frmTeams_Activated(object sender, EventArgs e)
        {
            //The grid with all the tasks will load.
            fillGridView();

            // DataGridView Configuration
            dgvTeams.AutoResizeColumns();
            dgvTeams.AllowUserToAddRows = false;
            dgvTeams.AllowUserToDeleteRows = false;
            dgvTeams.AllowUserToResizeRows = false;
            dgvTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeams.MultiSelect = false;
            dgvTeams.RowHeadersVisible = false; // We hide the rowheader
            dgvTeams.ClearSelection(); // Clear selection rows
        }
    }
}
