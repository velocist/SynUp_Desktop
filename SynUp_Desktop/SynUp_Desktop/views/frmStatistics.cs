﻿using SynUp_Desktop.controller;
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
    public partial class frmStatistics : Form
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
            hideAllComponents();

            init();
        }

        /// <summary>
        /// Event that runs when the button back is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Search action performed after the user selects a filter and its parameters. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Note: He modificado para que cada uno este en un metodo. Mas modular
            switch (cmbFilter.SelectedIndex)
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
        }
        
        /// <summary>
        /// Event that runs when the selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAllComponents();

            switch (cmbFilter.SelectedIndex)
            {
                case 1:
                    showComponentsFirst();
                    break;
                case 2:
                    showComponentsSecond();
                    break;
                case 3:
                    showComponentsThird();
                    break;
                case 4:
                    showComponentsForth();
                    break;
                case 5:
                    showComponentsFifth();
                    break;
            }
        }

        #region SHOW COMPONENTS BY SELECTED FILTER

        /// <summary>
        /// Shows the components of the first filter (task available in a date)
        /// </summary>
        private void showComponentsFirst()
        {
            checkSearchButton();

            setInstructions("Select the period to filter the tasks within:");
            lblDate1.Visible = true;
            lblDate2.Visible = true;

            dtpBegin.Visible = true;
            dtpEnd.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (tasks in a team)
        /// </summary>
        private void showComponentsSecond()
        {
            checkSearchButton();
            setInstructions("Select the team:");
            cmbTeams.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (task assigned to an employee)
        /// </summary>
        private void showComponentsThird()
        {
            checkSearchButton();
            setInstructions("Select the employee:");
            cmbEmployee.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (tasks by state)
        /// </summary>
        private void showComponentsForth()
        {
            checkSearchButton();
            setInstructions("Select the state you want to filter:");
            cmbStates.Visible = true;
        }

        /// <summary>
        /// Shows the components of the first filter (list of teams or employees ordered by most availabe tasks assigned)
        /// </summary>
        private void showComponentsFifth()
        {
            checkSearchButton();
            setInstructions("Select the period and the object:");
            lblDate1.Visible = true;
            lblDate2.Visible = true;

            dtpBegin.Visible = true;
            dtpEnd.Visible = true;
            cmbRanking.Visible = true;
            //
        }

        #endregion
        
        #region METHOD'S FILTERS
        /// <summary>
        /// Method that filter tasks by date
        /// </summary>
        private void filterByDate()
        {
            DateTime start = dtpBegin.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            if (start != null && end != null && start.CompareTo(end) < 0)
            {
                fillDataGrid(Controller.StatisticsService.getTasksByDate(start, end));
            }
            else
            {
                clMessageBox.showMessage(clMessageBox.ACTIONTYPE.WRONG, null, false, this);
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
                MessageBox.Show(strCode);
                fillDataGrid(Controller.StatisticsService.getTasksByTeam(strCode));
            }
            else
            {
                clMessageBox.showMessage(clMessageBox.ACTIONTYPE.WRONG, null, false, this);
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
                fillDataGrid(Controller.StatisticsService.getTasksByEmployee(strNif));
            }
            else
            {
                clMessageBox.showMessage(clMessageBox.ACTIONTYPE.WRONG, null, false, this);
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
                fillDataGrid(Controller.StatisticsService.getTasksByState(strState));
            }
            else
            {
                clMessageBox.showMessage(clMessageBox.ACTIONTYPE.WRONG, null, false, this);
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

            if (start != null && end != null && start.CompareTo(end) < 0 && (!strFilter.Equals("") || !strFilter.Equals(null)))
            {
                strFilter = strFilter.ToLower().Trim();
                switch (strFilter)
                {
                    case "employees":
                        fillDataGrid(Controller.StatisticsService.getRankingEmployees(start, end));
                        break;
                    case "teams":
                        fillDataGrid(Controller.StatisticsService.getRankingTeams(start, end));
                        break;
                }
            }
            else
            {
                clMessageBox.showMessage(clMessageBox.ACTIONTYPE.WRONG, null, false, this);
            }
        }

        #endregion

        private void setInstructions(String text)
        {
            lblInstructions.Visible = true;
            lblInstructions.Text = text;
        }

        /// <summary>
        /// Hides all the filter components in the form.
        /// </summary>
        private void hideAllComponents()
        {
            btnSearch.Enabled = false;

            //labels
            lblDate1.Visible = false;
            lblDate2.Visible = false;
            lblInstructions.Visible = false;

            //components
            cmbEmployee.Visible = false;
            cmbStates.Visible = false;
            cmbTeams.Visible = false;
            cmbRanking.Visible = false;
            dtpBegin.Visible = false;
            dtpEnd.Visible = false;
        }

        /// <summary>
        /// Checks whether the search button is active or not
        /// </summary>
        private void checkSearchButton()
        {
            if (btnSearch.Enabled == false)
            {
                btnSearch.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_data">Will receive the lists that the datagrid will be filled with.</param>
        private void fillDataGrid(Object _data)
        {
            BindingSource source = new BindingSource();
            source.DataSource = _data;
            this.dgvStadistics.DataSource = source;
        }

        private void init()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Controller.TeamService.getAllTeams();
            cmbTeams.DataSource = source;
            cmbTeams.DisplayMember = "Name";
            cmbTeams.ValueMember = "code";
            cmbTeams.DropDownStyle = ComboBoxStyle.DropDownList;

            source = new BindingSource();
            source.DataSource = Controller.EmployeeService.getAllEmployees();
            cmbEmployee.DataSource = source;
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "nif";
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbStates.SelectedIndex = 0;
            cmbStates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRanking.SelectedIndex = 0;
            cmbRanking.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.SelectedIndex = 0;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            string dateFormat = "dddd dd, MMMM yyyy";

            dtpBegin.CustomFormat = dateFormat;
            dtpEnd.CustomFormat = dateFormat;
        }
    }
}
