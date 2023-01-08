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
    public partial class AddNewEmployee : Form
    {
        private long DepartmentID { get; set; }
        Database _db;
        public AddNewEmployee(long departmentID)
        {
            InitializeComponent();
            DepartmentID = departmentID;
            _db  = new Database();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            string q = $"INSERT INTO \"TemporalDB\".\"Employees\" (\"Name\", \"Surname\", \"OIB\", \"HourlyRate\", \"DepartmentID\") " +
                $"VALUES ('{txtName.Text}', '{txtSurname.Text}', '{txtOIB.Text}', {txtHourlyRate.Text}, {DepartmentID})";
            try
            {
                _db.Connect();
                _db.ExecuteQuery(q);
                _db.Disconnect();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }
    }
}
