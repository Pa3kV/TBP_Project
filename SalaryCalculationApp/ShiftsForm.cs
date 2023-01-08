﻿using System;
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
    public partial class ShiftsForm : Form
    {
        private long EmployeeID { get; set; }
        private string FullName { get; set; }
        private  string OIB { get; set; }
        Database _db;
        public ShiftsForm(long empID, string fullName, string oib, Database db)
        {
            InitializeComponent();
            EmployeeID = empID;
            _db = db;
            FullName = fullName;
            OIB = oib;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShiftsForm_Load(object sender, EventArgs e)
        {
            lblEmployee.Text = $"{FullName} ({OIB}):";

            string q = $"SELECT * FROM \"TemporalDB\".\"Shifts\" WHERE \"EmployeeID\" = {EmployeeID} ORDER BY \"ID\"";
            var reader = _db.ExecuteQuery(q);
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvShifts.DataSource = dt;
                dgvShifts.Columns["ID"].Visible = false;
                dgvShifts.Columns["EmployeeID"].Visible = false;
            }
            reader.Close();
        }
    }
}
