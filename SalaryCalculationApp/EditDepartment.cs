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
    public partial class EditDepartment : Form
    {
        Database _db;
        private long DepartmentID { get; set; }
        public EditDepartment(long depID, string depName, Database db)
        {
            InitializeComponent();
            DepartmentID = depID;
            txtName.Text = depName;
            _db = db;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditDep_Click(object sender, EventArgs e)
        {
            string q = $"UPDATE \"TemporalDB\".\"Departments\" SET \"Name\" = '{txtName.Text}' WHERE \"ID\" = {DepartmentID}";
            _db.ExecuteNonQuery(q);
            Close();
        }
    }
}
