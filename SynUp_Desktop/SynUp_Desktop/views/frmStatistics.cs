using SynUp_Desktop.controller;
using SynUp_Desktop.utilities;
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
    /// Forms stadistics
    /// </summary>
    public partial class frmStatistics : Form
    {
        private Controller controller;
        private int minHeight = 510;
        private int maxHeight = 570;

        private Boolean _blHelp = false; //Global variable that indicates whether this active support

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

        public frmStatistics()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Iniializes the form filling all the comboboxes with the respective data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            this.hideAllComponents();

            this.init();

            this._blHelp = false;

            //Configurates form
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Search action performed after the user selects a filter and its parameters. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Note: He modificado para que cada uno este en un metodo. Mas modular
            switch (this.cmbFilter.SelectedIndex)
            {
                case 1:
                    this.filterByDate();
                    break;
                case 2:
                    this.filterByTeam();
                    break;
                case 3:
                    this.filterByEmployee();
                    break;
                case 4:
                    this.filterByState();
                    break;
                case 5:
                    this.filterRanking();
                    break;
            }
            this.dgvStadistics.ClearSelection(); // Clear selection rows
            this.dgvStadistics.Refresh();
        }

        /// <summary>
        /// Event that runs when the selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAllComponents();

            switch (this.cmbFilter.SelectedIndex)
            {
                case 1:
                    this.showComponentsFirst();
                    break;
                case 2:
                    this.showComponentsSecond();
                    break;
                case 3:
                    this.showComponentsThird();
                    break;
                case 4:
                    this.showComponentsForth();
                    break;
                case 5:
                    this.showComponentsFifth();
                    break;
            }
        }

        #region SHOW COMPONENTS BY SELECTED FILTER

        /// <summary>
        /// Shows the components of the first filter (task available in a date)
        /// </summary>
        private void showComponentsFirst()
        {
            this.checkSearchButton();

            this.setInstructions("Select the period to filter the tasks within:");
            this.lblDate1.Visible = true;
            this.lblDate2.Visible = true;

            this.dtpBegin.Visible = true;
            this.dtpEnd.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (tasks in a team)
        /// </summary>
        private void showComponentsSecond()
        {
            this.checkSearchButton();
            this.setInstructions("Select the team:");
            this.cmbTeams.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (task assigned to an employee)
        /// </summary>
        private void showComponentsThird()
        {
            this.checkSearchButton();
            this.setInstructions("Select the employee:");
            this.cmbEmployee.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (tasks by state)
        /// </summary>
        private void showComponentsForth()
        {
            this.checkSearchButton();
            this.setInstructions("Select the state you want to filter:");
            this.cmbStates.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (list of teams or employees ordered by most availabe tasks assigned)
        /// </summary>
        private void showComponentsFifth()
        {
            this.checkSearchButton();
            this.setInstructions("Select the period and the object:");
            this.lblDate1.Visible = true;
            this.lblDate2.Visible = true;

            this.dtpBegin.Visible = true;
            this.dtpEnd.Visible = true;
            this.cmbRanking.Visible = true;
            //
        }

        #endregion

        #region FILTER METHODS
        /// <summary>
        /// Method that filter tasks by date
        /// </summary>
        private void filterByDate()
        {
            DateTime start = dtpBegin.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            if (start != null && end != null && start.CompareTo(end) <= 0)
            {
                this.fillDataGrid(Controller.StatisticsService.getTasksByDate(start, end));
                this.dgvConfigurationTasks();
            }
            else
            {
                this.HelpMessage(Literal.WARNING_DATEDIFF_STATISTICS, (int)HelpIcon.WARNING);
                //clMessageBox.showMessage(clMessageBox.MESSAGE.WRONG, null, this);
            }


        }

        /// <summary>
        ///  Method that filter tasks by team
        /// </summary>
        private void filterByTeam()
        {
            String strCode = (String)cmbTeams.SelectedValue;
            if (!strCode.Equals("") || !strCode.Equals(null))
            {
                //MessageBox.Show(strCode);
                this.fillDataGrid(Controller.StatisticsService.getTasksByTeam(strCode));
                this.dgvConfigurationTasks();
            }
            else
            {
                //clMessageBox.showMessage(clMessageBox.MESSAGE.WRONG, null, this);
                this.HelpMessage(Literal.WARNING_UNSELECTED_STATISTICS, (int)HelpIcon.WARNING);
            }
        }

        /// <summary>
        ///  Method that filter tasks by employee
        /// </summary>
        private void filterByEmployee()
        {
            String strNif = (String)cmbEmployee.SelectedValue;
            if (!strNif.Equals("") || !strNif.Equals(null))
            {
                this.fillDataGrid(Controller.StatisticsService.getTasksByEmployee(strNif));
                this.dgvConfigurationTasks();
            }
            else
            {
                //clMessageBox.showMessage(clMessageBox.MESSAGE.WRONG, null, this);
                this.HelpMessage(Literal.WARNING_UNSELECTED_STATISTICS, (int)HelpIcon.WARNING);
            }
        }

        /// <summary>
        ///  Method that filter tasks by state
        /// </summary>
        private void filterByState()
        {
            String strState = cmbStates.SelectedItem.ToString();
            if (!strState.Equals("") || strState.Equals(null))
            {
                this.fillDataGrid(Controller.StatisticsService.getTasksByState(strState));
                this.dgvConfigurationTasks();
            }
            else
            {
                //clMessageBox.showMessage(clMessageBox.MESSAGE.WRONG, null, this);
                this.HelpMessage(Literal.WARNING_UNSELECTED_STATISTICS, (int)HelpIcon.WARNING);
            }
        }

        /// <summary>
        ///  Method that show ranking
        /// </summary>
        private void filterRanking()
        {
            DateTime start = dtpBegin.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            String strFilter = cmbRanking.SelectedItem.ToString();

            if (start != null && end != null && start.CompareTo(end) <= 0 && (!strFilter.Equals("") || !strFilter.Equals(null)))
            {
                strFilter = strFilter.ToLower().Trim();
                switch (strFilter)
                {
                    case "employees":
                        this.fillDataGrid(Controller.StatisticsService.getRankingEmployees(start, end));
                        break;
                    case "teams":
                        this.fillDataGrid(Controller.StatisticsService.getRankingTeams(start, end));
                        break;
                }
            }
            else
            {
                //clMessageBox.showMessage(clMessageBox.MESSAGE.WRONG, null, this);
                this.HelpMessage(Literal.WARNING_UNSELECTED_STATISTICS + " or " + Literal.WARNING_DATEDIFF_STATISTICS, (int)HelpIcon.WARNING);
            }
        }

        #endregion

        /// <summary>
        /// Configuring the method in the case dgv tasks
        /// </summary>
        private void dgvConfigurationTasks()
        {
            //Column configuration
            this.dgvStadistics.Columns[0].Visible = false; // We hide id column
            //dgvTasks.Columns["code_team"].Visible = true; // We hide the id_team column
            this.dgvStadistics.Columns[1].HeaderText = "Code"; // We change the column name
            this.dgvStadistics.Columns[2].HeaderText = "Name";
            this.dgvStadistics.Columns[3].HeaderText = "Priority Date";
            this.dgvStadistics.Columns[4].Visible = false; // HeaderText = "Description";
            this.dgvStadistics.Columns[5].Visible = false; // HeaderText = "Localization";
            this.dgvStadistics.Columns[6].HeaderText = "Project";
            this.dgvStadistics.Columns[7].HeaderText = "Priority"; //priority
            this.dgvStadistics.Columns[8].HeaderText = "State"; //state
            this.dgvStadistics.Columns[9].Visible = false; // HeaderText = "Team";
            this.dgvStadistics.Columns[10].Visible = false; // HeaderText = "Task Histories";
        }

        /// <summary>
        /// Method that configurates the datagridview
        /// </summary>
        private void dgvConfiguration()
        {
            // DatagridView Common Configuration
            this.dgvStadistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Fill columns size the datagridview
            this.dgvStadistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selected complet row     
            this.dgvStadistics.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvStadistics.AllowUserToAddRows = false; // Can't add rows
            this.dgvStadistics.AllowUserToDeleteRows = false; // Can't delete rows
            this.dgvStadistics.AllowUserToOrderColumns = false; //Can order columns
            this.dgvStadistics.AllowUserToResizeRows = false; //Can't resize columns
            this.dgvStadistics.Cursor = Cursors.Hand; // Cursor hand type            
            this.dgvStadistics.MultiSelect = false; //Can't multiselect
            this.dgvStadistics.RowTemplate.ReadOnly = true;
            this.dgvStadistics.RowHeadersVisible = false; // We hide the rowheader           

        }

        private void setInstructions(String text)
        {
            this.lblInstructions.Visible = true;
            this.Text = text;
        }

        /// <summary>
        /// Hides all the filter components in the form.
        /// </summary>
        private void hideAllComponents()
        {
            this.btnSearch.Enabled = false;

            //labels
            this.lblDate1.Visible = false;
            this.lblDate2.Visible = false;
            this.lblInstructions.Visible = false;

            //components
            this.cmbEmployee.Visible = false;
            this.cmbStates.Visible = false;
            this.cmbTeams.Visible = false;
            this.cmbRanking.Visible = false;
            this.dtpBegin.Visible = false;
            this.dtpEnd.Visible = false;
            this.chtStatistics.Visible = false;

            this.HelpMessage("", (int)HelpIcon.INFORMATION);
            _blHelp = utilities.Help.hideShowHelp(true, this, minHeight, maxHeight);

        }

        /// <summary>
        /// Checks whether the search button is active or not
        /// </summary>
        private void checkSearchButton()
        {
            if (this.btnSearch.Enabled == false)
            {
                this.btnSearch.Enabled = true;
            }
        }

        /// <summary>
        /// Method that fills the datagridview
        /// </summary>
        /// <param name="_data">Will receive the lists that the datagrid will be filled with.</param>
        private void fillDataGrid(Object _data)
        {
            //if(_data=null) 

            BindingSource source = new BindingSource();
            source.DataSource = _data;
            this.dgvStadistics.DataSource = source;

            if(this.dgvStadistics.RowCount<=0) this.HelpMessage(Literal.WARNING_EMPTY_STATISTICS, (int)HelpIcon.WARNING);
            else _blHelp = utilities.Help.hideShowHelp(true, this, minHeight, maxHeight);

            /* this.chtStatistics.DataSource = source;

             //chtStatistics.Series["state"].Points.AddXY("Max",33);
             //chtStatistics.Update();
             this.chtStatistics.DataBind();
             this.chtStatistics.Visible = true;*/

        }

        /// <summary>
        /// Methos that loads all combobox 
        /// </summary>
        private void init()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();
            this.cmbTeams.DataSource = source;
            this.cmbTeams.DisplayMember = "Name";
            this.cmbTeams.ValueMember = "code";
            this.cmbTeams.DropDownStyle = ComboBoxStyle.DropDownList;

            source = new BindingSource();
            source.DataSource = Controller.EmployeeService.getAllEmployees();
            this.cmbEmployee.DataSource = source;
            this.cmbEmployee.DisplayMember = "Name";
            this.cmbEmployee.ValueMember = "nif";
            this.cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbStates.SelectedIndex = 0;
            this.cmbStates.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRanking.SelectedIndex = 0;
            this.cmbRanking.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFilter.SelectedIndex = 0;
            this.cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            string dateFormat = "dddd dd, MMMM yyyy";

            this.dtpBegin.CustomFormat = dateFormat;
            this.dtpEnd.CustomFormat = dateFormat;
            this.dtpBegin.Format = DateTimePickerFormat.Custom;
            this.dtpEnd.Format = DateTimePickerFormat.Custom;

            this.chtStatistics.Visible = false;

            this.dgvConfiguration();
        }

        #region HELP

        /// <summary>
        /// Event that runs when the button help is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_MouseClick(object sender, MouseEventArgs e)
        {

            _blHelp = utilities.Help.hideShowHelp(_blHelp, this, minHeight, maxHeight);
            if (_blHelp) this.HelpMessage("", (int)HelpIcon.WARNING);
            this.walkingControls();
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
                this.HelpMessage("", (int)HelpIcon.WARNING);
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
                string _message = sender.ToString();

                if (sender.Equals(this.btnSearch))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para buscar.";
                }
                else if (sender.Equals(this.dgvStadistics))
                {
                    this.lblHelpMessage.Text = "Lista de los registros encontrados.";
                }
                else if (sender.Equals(this.btnBack))
                {
                    this.lblHelpMessage.Text = "Clicke aquí para volver al menú principal.";
                }
                else if (sender.Equals(this.cmbFilter))
                {
                    this.lblHelpMessage.Text = "Escoja un filtro para buscar.";
                }
                else if (sender.Equals(this.cmbEmployee))
                {
                    this.lblHelpMessage.Text = "Escoja el empleado que desee filtrar.";
                }
                else if (sender.Equals(this.cmbTeams))
                {
                    this.lblHelpMessage.Text = "Escoja el equipo que desee filtrar.";
                }
                else if (sender.Equals(this.cmbStates))
                {
                    this.lblHelpMessage.Text = "Escoja el estado que desee filtrar.";
                }
                else if (sender.Equals(this.cmbRanking))
                {
                    this.lblHelpMessage.Text = "Escoja para buscar por ránking.";
                }
                else if (sender.Equals(this.dtpBegin))
                {
                    this.lblHelpMessage.Text = "Escoja la fecha de inicio.";
                }
                else if (sender.Equals(this.dtpEnd))
                {
                    this.lblHelpMessage.Text = "Escoja la fecha final.";
                }

                this.HelpMessage(_message, (int)HelpIcon.INFORMATION);
            }
        }

        /// <summary>
        /// Method that walkings all controls in form
        /// </summary>
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
        /// Methd that sohws message wrong
        /// </summary>
        private void HelpMessage(String message, int icon)
        {
            this.Height = maxHeight;
            this.pbxIconMessage.Image = utilities.Help.changeIconMessage(icon);
            this.lblHelpMessage.Text = message;
        }

        #endregion

    }
}

/* DELETES: Cristina C. Generic button
/// <summary>
/// Event that runs when the button back is clicked
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnBack_Click(object sender, EventArgs e)
{
    this.Close();
}
*/
