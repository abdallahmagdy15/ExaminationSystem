﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ManageStudent mStudent = new ManageStudent();
            this.Visible = false;
            mStudent.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            MangeDepartment form = new MangeDepartment();
            this.Visible = false;
            form.ShowDialog();
        }
    }
}
