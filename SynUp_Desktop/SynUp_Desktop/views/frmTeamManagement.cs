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

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {

            String _strCode = txtCode.Text;
            String _strName = txtName.Text;

            Boolean createOk = TaskService.createTeam(_strCode, _strName);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.AuxTeam = null;
            this.clearValues();
            this.Close();
        }

        private void clearValues()
        {
            txtCode.Text = "";
            txtName.Text = "";

        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            model.pojo.Team deleteTeam = TaskService.deleteTeam(AuxTeam);
            if (deleteTeam != null)
            {
                MessageBox.Show("This team was delete succesfully");
                this.btnBack_Click(sender, e);
            }
            else {
                MessageBox.Show("This team wasn't delete succesfully");
            }
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals("")) // We found that the textbox is not emtpty
            {
                lblCode.ForeColor = Color.Red;
                lblCode.Text = "Code*";
            }

            String _strIdCode = txtCode.Text;
            model.pojo.Team _oTeam = TaskService.readTeam(_strIdCode); // We look for if the task already exists

            if (_oTeam != null) // If the task exists, we show a message
            {
                MessageBox.Show("This code already exists");
                lblCode.Text = "Code*";
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            lblCode.Text = "Code";
            lblCode.ForeColor = Color.Black;
        }
    }
}

