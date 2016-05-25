using SynUp_Desktop.controller;
using SynUp_Desktop.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SynUp_Desktop.views
{
    /// <summary>
    /// Form of list teams
    /// </summary>
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
        /// Event that runs when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeams_Load(object sender, EventArgs e)
        {
            //The grid with all the teams will load.
            this.frmTeams_Activated(sender, e);
            this.dgvConfiguration();

            this.walkingControls();
            this.gbContainer.MouseClick += new MouseEventHandler(this.frmTeams_MouseClick);
            this.gbHelp.MouseClick += new MouseEventHandler(this.frmTeams_MouseClick);
            utilities.Util.loadMenu(this, this.controller);
        }

        /// <summary>
        /// Event that runs when the form is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeams_Activated(object sender, EventArgs e)
        {
            //The grid with all the teams will load.
            this.fillGrid();
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

            this.Controller.TeamMgtView.ShowDialog();
        }

        /// <summary>
        /// Event that runs when mouse click on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeams_MouseClick(object sender, MouseEventArgs e)
        {
            this.dgvTeams.ClearSelection();
            this.dgvTeams.Refresh();
        }

        /// <summary>
        /// DataGridView configuration.
        /// </summary>
        private void dgvConfiguration()
        {
            //Form Common Configurations
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

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
            this.dgvTeams.AutoResizeColumns();
        }

        /// <summary>
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        private void fillGrid()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();
            this.dgvTeams.DataSource = source;
            this.dgvTeams.ClearSelection();
            this.dgvTeams.Refresh();
            this.Refresh();
        }

        #region HELP

        /* DELETED - HELP ALWAYS VISIBLE 24/5/16
        
        private Boolean _blHelp = false;

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {
            _blHelp = utilities.Help.hideShowHelp(_blHelp, this, this.MinimumSize.Height, this.MaximumSize.Height);
            if (_blHelp) this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
            this.walkingControls();

            /* (_blHelp)
            {
                _blHelp = false;
                this.lblHelpMessage.Text = "";
                this.changeIconMessage(0);
                this.walkingControls(true);
            }
            else
            {
                _blHelp = true;
                this.lblHelpMessage.Text = "";
                this.changeIconMessage(0);
                this.walkingControls(false);
            
        }*/

        /// <summary>
        /// Event that runs when the mouse leaves labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseLeave(object sender, EventArgs e)
        {
            this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
        }

        /// <summary>
        /// Event that runs when the mouse hover on components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseHover(object sender, EventArgs e)
        {
            int _icon = (int)utilities.Help.HelpIcon.INFORMATION;
            String _message = "";
            if (sender.Equals(this.btnManagementTeams))
            {
                _message = Literal.INFO_BTN_MANAGEMENT;
            }
            else if (sender.Equals(this.dgvTeams))
            {
                _message = Literal.INFO_DGV;
            }
            else if (sender.Equals(this.btnBack))
            {
                _message = Literal.INFO_BTN_BACK;
            }
            this.HelpMessage(_message, _icon);
        }

        /// <summary>
        /// Method that walkings all controls in form
        /// </summary>
        /// <param name="pEnabled"></param>
        private void walkingControls()
        {
            foreach (Control _control in this.Controls) //Recorremos los componentes del formulario
            {
                if (_control is GroupBox)
                {
                    foreach (Control _inGroupBox in _control.Controls) //Recorrecmos los componentes del groupbox
                    {
                        _inGroupBox.MouseHover += new EventHandler(messageHelps_MouseHover);
                        _inGroupBox.MouseLeave += new EventHandler(messageHelps_MouseLeave);
                    }
                }
                if (_control is Button)
                {
                    _control.MouseHover += new EventHandler(messageHelps_MouseHover);
                    _control.MouseLeave += new EventHandler(messageHelps_MouseLeave);
                }
                if (_control is GenericButton)
                {
                    _control.MouseHover += new EventHandler(messageHelps_MouseHover);
                    _control.MouseLeave += new EventHandler(messageHelps_MouseLeave);
                }
            }
        }

        /// <summary>
        /// Method that shows message help
        /// </summary>
        private void HelpMessage(String message, int icon)
        {
            this.Height = this.MaximumSize.Height;
            this.pbxIconMessage.Image = utilities.Help.changeIconMessage(icon);
            this.lblHelpMessage.Text = message;
        }

        #endregion

    }
}

/* DELETE: Cristina C. 21052016 Change for generic button
  /// <summary>
        /// Event that runs when clicked botton back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
*/

