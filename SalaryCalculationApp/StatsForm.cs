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
    public partial class StatsForm : Form
    {
        private long EmployeeID { get; set; }
        Database _db;
        public StatsForm(long empID, Database db)
        {
            InitializeComponent();
            EmployeeID = empID;
            _db = db;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            string q = $"SELECT * FROM \"TemporalDB\".\"EmployeesTotal\" WHERE \"EmployeeID\" = {EmployeeID}";
            var reader = _db.ExecuteQuery(q);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtHours.Text = reader.GetInt64(1).ToString();
                    txtWage.Text = reader.GetDecimal(2).ToString();
                    txtMonths.Text = reader.GetInt32(3).ToString();
                }
            }
            reader.Close();
        }
    }
}
