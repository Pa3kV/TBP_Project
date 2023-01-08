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
    public partial class RegisterShiftForm : Form
    {
        private long EmployeeID { get; set; }
        Database _db;
        public RegisterShiftForm(long empID)
        {
            InitializeComponent();
            EmployeeID = empID;
            _db = new Database();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegisterShift_Click(object sender, EventArgs e)
        {
            if (dtpFromTime.Value < dtpToTime.Value)
            {
                string q = $"INSERT INTO \"TemporalDB\".\"Shifts\" (\"EmployeeID\", \"ShiftStart\", \"ShiftEnd\", \"ShiftDate\")" +
                    $" VALUES ({EmployeeID}, '{dtpFromTime.Value}', '{dtpToTime.Value}', '{dtpDate.Value}')";
                try 
                {
                    _db.Connect();
                    _db.ExecuteNonQuery(q);
                    _db.Disconnect();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Start time should have lesser value than end time");
            }
        }
    }
}
