using SynUp_Desktop.controller;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.service;
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
    public partial class frmTeamManagement : Form
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

        public Team AuxTeam;

        public frmTeamManagement()
        {
            InitializeComponent();
        }

        #region
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {

            String _strCode = txtCode.Text;
            String _strName = txtName.Text;

            Boolean createOk = Controller.TeamService.createTeam(_strCode, _strName);

            if (createOk)
            {
                MessageBox.Show("The team was created succesfully!");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("The team wasn't created succesfully!");
            }


        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            Team deleteTeam = Controller.TeamService.deleteTeam(AuxTeam);
            if (deleteTeam != null)
            {
                MessageBox.Show("This team was delete succesfully");
                this.btnBack_Click(sender, e);
            }
            else
            {
                MessageBox.Show("This team wasn't delete succesfully");
            }
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.AuxTeam = null;
            this.clearValues();
            this.Close();
        }

        private void frmTeamManagement_Activated(object sender, EventArgs e)
        {


            // DatagridView Common Configuration 
            this.dgvEmployeesOnTeam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvEmployeesOnTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row            
            this.dgvEmployeesOnTeam.AllowUserToAddRows = false; // Can't add rows
            this.dgvEmployeesOnTeam.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvEmployeesOnTeam.AllowUserToOrderColumns = false; //Can't order columns
            this.dgvEmployeesOnTeam.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvEmployeesOnTeam.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvEmployeesOnTeam.MultiSelect = false; //Can't multiselect
            this.dgvEmployeesOnTeam.RowTemplate.ReadOnly = true;
            this.dgvEmployeesOnTeam.RowHeadersVisible = false; // We hide the rowheader
            this.dgvEmployeesOnTeam.ClearSelection(); // Clear selection rows

            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        /// <summary>
        /// Clear values of textboxs
        /// </summary>
        private void clearValues()
        {
            this.txtCode.Text = "";
            this.txtName.Text = "";
            this.dgvEmployeesOnTeam.ClearSelection();
        }

        private void fillDataGrid()
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            String _strIdCode = txtCode.Text;
            Team _oTeam = Controller.TeamService.readTeam(_strIdCode);

            if (txtCode.Text.Equals("") || _oTeam != null) // We found that the textbox is not emtpty
            {
                lblCode.ForeColor = Color.Red;
                lblCode.Text = "Code*";
            }
            else
            {
                lblCode.Text = "Code";
                lblCode.ForeColor = Color.Black;
            }
            
        }

    }
}

