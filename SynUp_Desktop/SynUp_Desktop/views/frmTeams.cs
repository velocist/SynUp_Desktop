using SynUp_Desktop.controller;
using System;
using System.Collections.Generic;
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
            model.pojo.Team _oSelectedTeam = null;
            if (this.dgvTeams.SelectedRows.Count == 1)//If the row selected
            {
                int _iIndexSelected = this.dgvTeams.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = this.dgvTeams.Rows[_iIndexSelected].Cells[0].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedTeam = Controller.TeamService.readTeam(_strSelectedRowCode); // We look for the employee nif
                    this.Controller.TeamMgtView.AuxTeam = _oSelectedTeam; // We assign the team to form team management
                }
            }

            //this.Hide();
            this.Controller.TeamMgtView.ShowDialog();
            //this.Show();
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
        /// DataGridView configuration.
        /// </summary>
        private void initGridView()
        {
            this.fillGridView();

            //Column configuration

            this.dgvTeams.Columns[0].HeaderText = "Code"; // We change the column name
            this.dgvTeams.Columns[1].HeaderText = "Name";
            this.dgvTeams.Columns[2].Visible = false;
            this.dgvTeams.Columns[3].Visible = false;

            // DatagridView Common Configuration 

            this.dgvTeams.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTeams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row            
            this.dgvTeams.AllowUserToAddRows = false; // Can't add rows
            this.dgvTeams.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvTeams.AllowUserToOrderColumns = false; //Can't order columns
            this.dgvTeams.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvTeams.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvTeams.MultiSelect = false; //Can't multiselect
            this.dgvTeams.RowTemplate.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false; // We hide the rowheader
            this.dgvTeams.ClearSelection(); // Clear selection rows
            this.dgvTeams.AutoResizeColumns();

            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void frmTeams_Activated(object sender, EventArgs e)
        {
            //The grid with all the teams will load.
            //dgvTeams.DataSource = null;
            initGridView();
            //dgvTeams.EndEdit();
            

            //this.fillGridView();
            //dgvTeams.ClearSelection();
            //dgvTeams.Update();
            //dgvTeams.Refresh();
        }

        private void frmTeams_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        /// <summary>
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        private void fillGridView()
        {
            if (dgvTeams.DataSource != null) dgvTeams.DataSource = new List<String>();

            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();
            this.dgvTeams.DataSource = source;
            this.dgvTeams.Refresh();
            this.Refresh();
        }
    }
}
