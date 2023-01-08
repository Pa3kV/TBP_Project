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
    public partial class ChangeHourlyRateForm : Form
    {
        private long EmployeeID { get; set; }
        private decimal OldValue { get; set; }
        Database _db;
        public ChangeHourlyRateForm(long empID, Database db, decimal oldValue)
        {
            InitializeComponent();
            EmployeeID = empID;
            OldValue = oldValue;
            _db = db;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangeHR_Click(object sender, EventArgs e)
        {
            string q = $"UPDATE \"TemporalDB\".\"Employees\" SET \"HourlyRate\" = {txtNewValue.Text} WHERE \"ID\" = {EmployeeID}";
            try
            {
                _db.ExecuteNonQuery(q);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeHourlyRateForm_Load(object sender, EventArgs e)
        {
            txtNewValue.Text = OldValue.ToString();
        }
    }
}
