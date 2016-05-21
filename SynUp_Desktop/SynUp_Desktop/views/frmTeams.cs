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
            this.dgvConfiguration();
            this.frmTeams_Activated(sender, e);
        }

        /// <summary>
        /// Event that runs when the form is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTeams_Activated(object sender, EventArgs e)
        {
            //The grid with all the teams will load.
            this.fillGridView();
            this.dgvTeams.ClearSelection();
            this.dgvTeams.Refresh();

            //Cleans the auxiliars of form team
            this.Controller.TeamMgtView.AuxEmployee = null;
            this.Controller.TeamMgtView.AuxTeam = null;

            //We configures the groupbox help
            this._blHelp = false;
            this.gbHelp.Visible = false;
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
        /// Fills the DataGridView with the values of the database.
        /// </summary>
        private void fillGridView()
        {
            if (dgvTeams.DataSource == null) dgvTeams.DataSource = new List<String>();

            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();
            this.dgvTeams.DataSource = source;
            this.dgvTeams.Refresh();
            this.Refresh();
        }

        /// <summary>
        /// DataGridView configuration.
        /// </summary>
        private void dgvConfiguration()
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
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        #region HELP

        private Boolean _blHelp = false;

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {
            if (_blHelp)
            {
                _blHelp = false;
                this.lblHelpMessage.Text = "";
                this.changeIconMessage(0);
                this.walkingControls(true);
                this.gbHelp.Visible = false;
            }
            else
            {
                _blHelp = true;
                this.lblHelpMessage.Text = "";
                this.changeIconMessage(0);
                this.walkingControls(false);
                this.gbHelp.Visible = true;
            }
        }

        /// <summary>
        /// Event that runs when the mouse leaves labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseLeave(object sender, EventArgs e)
        {
            if (_blHelp)
            {
                this.changeIconMessage(0);
                this.lblHelpMessage.Text = "";
            }
        }

        /// <summary>
        /// Event that runs when the mouse hover on components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageHelps_MouseHover(object sender, EventArgs e)
        {
            if (_blHelp)
            {
                this.changeIconMessage(3);
                if (sender.Equals(this.btnManagementTeams))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para acceder al formulario de equipo.";
                }
                else if (sender.Equals(this.dgvTeams))
                {
                    this.lblHelpMessage.Text = "Lista de todos los equipos existentes en la base de datos.";
                }
                else if (sender.Equals(this.btnBack))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para volver al menú principal.";
                }
            }
        }

        /// <summary>
        /// Method that walkings all controls in form
        /// </summary>
        /// <param name="pEnabled"></param>
        private void walkingControls(Boolean pEnabled)
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
        /// Method that changes the icon message
        /// </summary>
        /// <param name="pIcon"></param>
        private void changeIconMessage(int pIcon)
        {
            String _strFilename = null;
            Bitmap _image = null;

            if (pIcon == 1)
            {
                _strFilename = Application.StartupPath + "\\warning.png";
            }
            else if (pIcon == 2)
            {
                _strFilename = Application.StartupPath + "\\error.png";
            }
            else if (pIcon == 3)
            {
                _strFilename = Application.StartupPath + "\\information.png";

            }
            //Configurates de icon message
            if (_strFilename != null)
            {
                _image = new Bitmap(_strFilename);
            }
            this.pbxIconMessage.Image = _image;

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
