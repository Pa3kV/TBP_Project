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
    public partial class EmployeesForm : Form
    {
        private long DeptID { get; set; }
        private string DeptName { get; set; }
        Database _db;
        public EmployeesForm(long depID, string name, Database db)
        {
            InitializeComponent();
            DeptID = depID;
            DeptName = name;
            _db = db;
            
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            GetEmployees();
            lblDepartment.Text += $" ({DeptName})";
        }

        private void GetEmployees()
        {
            string q = $"SELECT * FROM \"TemporalDB\".\"Employees\" WHERE \"DepartmentID\" = {DeptID} ORDER BY \"ID\"";
            var reader = _db.ExecuteQuery(q);
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvEmployees.DataSource = dt;
                dgvEmployees.Columns["DepartmentID"].Visible = false;
            }
            reader.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            long columnID = (long)dgvEmployees.CurrentRow.Cells[0].Value;
            string q = $"UPDATE \"TemporalDB\".\"Employees\" SET \"Active\" = false WHERE \"ID\" = {columnID}";
            _db.ExecuteNonQuery(q);
            RefreshGUI();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if((bool)dgvEmployees.CurrentRow.Cells[5].Value == false)
            {
                btnRelease.Enabled = false;
                btnChangeHourlyRate.Enabled = false;
            }
            else
            {
                btnRelease.Enabled = true;
                btnChangeHourlyRate.Enabled = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new AddNewEmployee(DeptID);
            frm.FormClosing += new FormClosingEventHandler(child_FormClosing);
            frm.ShowDialog();
        }
        private void child_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGUI();
        }

        private void btnChangeHourlyRate_Click(object sender, EventArgs e)
        {
            long empID = (long)dgvEmployees.CurrentRow.Cells[0].Value;
            decimal empHourlyRate = (decimal)dgvEmployees.CurrentRow.Cells[4].Value;
            var frm = new ChangeHourlyRateForm(empID, _db, empHourlyRate);
            frm.FormClosing += new FormClosingEventHandler(child_FormClosing);
            frm.ShowDialog();
        }

        private void btnRegisterShift_Click(object sender, EventArgs e)
        {
            long empID = (long)dgvEmployees.CurrentRow.Cells[0].Value;
            var frm = new RegisterShiftForm(empID);
            frm.ShowDialog();
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            long empID = (long)dgvEmployees.CurrentRow.Cells[0].Value;
            var frm = new StatsForm(empID, _db);
            frm.Show();
        }

        private void btnShowShifts_Click(object sender, EventArgs e)
        {
            long empID = (long)dgvEmployees.CurrentRow.Cells[0].Value;
            string fullName = (string)dgvEmployees.CurrentRow.Cells[1].Value + " " + (string)dgvEmployees.CurrentRow.Cells[2].Value;
            string oib = (string)dgvEmployees.CurrentRow.Cells[3].Value;
            var frm = new ShiftsForm(empID, fullName, oib, _db);
            frm.ShowDialog();
        }

        private void btnMonthlyWage_Click(object sender, EventArgs e)
        {
            long empID = (long)dgvEmployees.CurrentRow.Cells[0].Value;
            string fullName = (string)dgvEmployees.CurrentRow.Cells[1].Value + " " + (string)dgvEmployees.CurrentRow.Cells[2].Value;
            string oib = (string)dgvEmployees.CurrentRow.Cells[3].Value;
            var frm = new MonthlyWageForm(empID, fullName, oib, _db);
            frm.ShowDialog();
        }
    }
}
