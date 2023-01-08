using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationApp
{
    public partial class MainForm : Form
    {
        Database _db;
        public MainForm()
        {
            InitializeComponent();
            _db = new Database();
            _db.Connect();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            GetDepartments();
        }

        private void GetDepartments()
        {
            string q = "SELECT * FROM \"TemporalDB\".\"Departments\" ORDER BY \"ID\"";
            var reader = _db.ExecuteQuery(q);
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvDepartments.DataSource = dt;
            }
            reader.Close();
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            long columnID = (long)dgvDepartments.CurrentRow.Cells[0].Value;
            string columnName = (string)dgvDepartments.CurrentRow.Cells[1].Value;
            var frm = new EditDepartment(columnID, columnName, _db);
            frm.FormClosing += new FormClosingEventHandler(child_FormClosing);
            frm.Show();
        }

        private void child_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGUI();
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            long columnID = (long)dgvDepartments.CurrentRow.Cells[0].Value;
            string columnName = (string)dgvDepartments.CurrentRow.Cells[1].Value;
            var frm = new EmployeesForm(columnID, columnName, _db);
            frm.FormClosing += new FormClosingEventHandler(child_FormClosing);
            frm.Show();
        }
    }
}
