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
using SynUp_Desktop.service;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.utilities;

namespace SynUp_Desktop.views
{
    /// <summary>
    /// The forms of list tasks
    /// </summary>
    public partial class frmTasks : Form
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

        public frmTasks()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Event that runs when the form loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTasks_Load(object sender, EventArgs e)
        {
            this.frmTasks_Activated(sender, e);

            //Form Common Configurations
            FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.walkingControls();

            this.gbContainer.MouseClick += new MouseEventHandler(this.frmTasks_MouseClick);
            this.gbHelp.MouseClick += new MouseEventHandler(this.frmTasks_MouseClick);

            utilities.Util.loadMenu(this, this.controller);

        }

        /// <summary>
        /// Event triggered every time the view is displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTasks_Activated(object sender, EventArgs e)
        {
            this.fillGrid();
            this.dgvConfiguration();
        }

        /// <summary>
        /// Shows the management view window of the tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagementTasks_Click(object sender, EventArgs e)
        {
            model.pojo.Task _oSelectedTask = null;
            if (dgvTasks.SelectedRows.Count == 1)//If the row selected
            {
                int _iIndexSelected = dgvTasks.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = dgvTasks.Rows[_iIndexSelected].Cells[1].Value; //Modified: Pablo Ardèvol, Cells[2] to Cell[1] due to Database Change 
                if (_cell != null)
                {
                    String _strSelectedRowCode = (String)_cell;//_cell.ToString(); // Recover the code
                    _oSelectedTask = Controller.TaskService.readTask(_strSelectedRowCode); // We look for the task code
                    this.Controller.TaskMgtView.AuxTask = _oSelectedTask; // We assign the task to form task management
                }
            }

            this.Controller.TaskMgtView.ShowDialog();
        }

        /// <summary>
        /// Event that runs when mouse click on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTasks_MouseClick(object sender, MouseEventArgs e)
        {
            this.dgvTasks.ClearSelection();
            this.dgvTasks.Refresh();
        }

        /// <summary>
        /// DataGridView Configuration
        /// </summary>
        /// <author>Pablo Ardèvol</author>
        private void dgvConfiguration()
        {
            //Column configuration
            dgvTasks.Columns[0].Visible = false; // We hide id column
            //dgvTasks.Columns["code_team"].Visible = true; // We hide the id_team column
            dgvTasks.Columns[1].HeaderText = "Code"; // We change the column name
            dgvTasks.Columns[2].HeaderText = "Name";
            dgvTasks.Columns[3].HeaderText = "Priority Date";
            dgvTasks.Columns[4].Visible = false; // HeaderText = "Description";
            dgvTasks.Columns[5].Visible = false; // HeaderText = "Localization";
            dgvTasks.Columns[6].HeaderText = "Project";
            dgvTasks.Columns[7].Visible = false; //priority
            dgvTasks.Columns[8].HeaderText = "State"; //state
            dgvTasks.Columns[9].Visible = false; // HeaderText = "Team";
            dgvTasks.Columns[10].Visible = false; // HeaderText = "Task Histories";

            // DatagridView Common Configuration 
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row     
            dgvTasks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTasks.AllowUserToAddRows = false; // Can't add rows
            dgvTasks.AllowUserToDeleteRows = false; // Can't delete rows
            dgvTasks.AllowUserToOrderColumns = false; //Can order columns
            dgvTasks.AllowUserToResizeRows = false; //Can't resize columns
            dgvTasks.Cursor = Cursors.Hand; // Cursor hand type            
            dgvTasks.MultiSelect = false; //Can't multiselect
            dgvTasks.RowTemplate.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false; // We hide the rowheader           

        }

        /// <summary>
        /// Method that fill the grid
        /// </summary>
        private void fillGrid()
        {
            //The grid with all the tasks will load.
            BindingSource source = new BindingSource();
            source.DataSource = Controller.TaskService.getAllTasks();
            this.dgvTasks.DataSource = source;
            this.dgvTasks.ClearSelection(); // Clear selection rows        
            this.dgvTasks.Refresh();//Refresh the datagrid
            this.Refresh(); //Refresh the view.   
        }

        #region HELP


        /*private void btnHelp_MouseClick(object sender, EventArgs e)
        {
            //_blHelp = utilities.Help.hideShowHelp(_blHelp, this, this.MinimumSize.Height, this.MaximumSize.Height);
            //if (_blHelp) this.HelpMessage("", (int)utilities.Help.HelpIcon.NONE);
           // this.walkingControls();

            //if (blHELP)
            //{
            //    blHELP = false;
            //    this.lblHelpMessage.Text = "";
            //    this.changeIconMessage(0);
            //    this.walkingControls(true);
            //    this.gbHelp.Visible = false;
            //}
            //else
            //{
            //    blHELP = true;
            //    this.lblHelpMessage.Text = "";
            //    this.changeIconMessage(0);
            //    this.walkingControls(false);
            //    this.gbHelp.Visible = true;
            //}
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
            string _message = "";

            if (sender.Equals(this.btnManagementTasks))
            {
                _message = Literal.INFO_BTN_MANAGEMENT;
            }
            else if (sender.Equals(this.dgvTasks))
            {
                _message = Literal.INFO_DGV;
            }
            else if (sender.Equals(this.btnBack))
            {
                _message = Literal.INFO_BTN_BACK;
            }

            HelpMessage(_message, (int)utilities.Help.HelpIcon.INFORMATION);

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
            this.pbxIconMessage.Image = utilities.Help.changeIconMessage(icon);
            this.lblHelpMessage.Text = message;
        }


        #endregion

    }
}


/* DELETE: Genereic button
/// <summary>
/// Event that runs when clicked
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnBack_Click(object sender, EventArgs e)
{
    this.Close();
}
*/
