using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynUp_Desktop.controller;

namespace SynUp_Desktop.views
{
    public partial class frmAbout : Form
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

        public frmAbout()
        {
            InitializeComponent();
        }

        private void tmrAbout_Tick(object sender, EventArgs e)
        {
            if (this.pbxCredits.Location.Y >= 0)
            {
                this.pbxCredits.Location = new Point(this.pbxCredits.Location.X, this.pbxCredits.Location.Y - 1);
            }
            else
            {
                this.tmrAbout.Stop();
            }

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            tmrAbout.Start();
            this.pbxCredits.Location = new Point(this.pbxCredits.Location.X, 400);
        }

        private void frmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrAbout.Stop();
        }

    }
}
