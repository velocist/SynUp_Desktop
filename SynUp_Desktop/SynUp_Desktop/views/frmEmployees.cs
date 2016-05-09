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
    /// <summary>
    /// Form of list employees
    /// </summary>
    public partial class frmEmployees : Form
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

        public frmEmployees()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that runs when the button is clicked to manage employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagementEmployee_Click(object sender, EventArgs e)
        {
            model.pojo.Employee _oSelectedEmployee = null;
            if (dgvEmployees.SelectedRows.Count == 1)//If the row selected

            {
                int _iIndexSelected = dgvEmployees.SelectedRows[0].Index; // Recover the index of selected row
                Object _cell = dgvEmployees.Rows[_iIndexSelected].Cells[2].Value;
                if (_cell != null)
                {
                    String _strSelectedRowCode = _cell.ToString(); // Recover the code
                    _oSelectedEmployee = Controller.EmployeeService.readEmployee(_strSelectedRowCode); // We look for the task code
                    this.Controller.EmployeeMgtView.AuxEmployee = _oSelectedEmployee; // We assign the task to form task management
                }

            }

            this.Controller.EmployeeMgtView.ShowDialog();
        }

        /// <summary>
        /// Event that runs when the button is clicked to add team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            //TODO Mostrar dialogo con combo para elegir equipo, o Mostrar la lista de equipos
        }

        /// <summary>
        /// Event that runs when the button is clicked to return back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Controller.MainView.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployees_Activated(object sender, EventArgs e)
        {

            //The grid with all the tasks will load.
            fillGridView();

            // DataGridView Configuration
            dgvEmployees.Columns[0].Visible = false; // We hide id column

            dgvEmployees.AutoResizeColumns();
            dgvEmployees.RowHeadersVisible = false; // We hide the rowheader
            dgvEmployees.ClearSelection(); // Cleer selection rows
        }

        /// <summary>
        /// 
        /// </summary>
        private void fillGridView()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Controller.EmployeeService.getAllEmployees();

            dgvEmployees.DataSource = source;

            dgvEmployees.Refresh();
        }
    }
}
