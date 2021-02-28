using System;
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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            mangeStudent mStudent = new mangeStudent();
            this.Visible = false;
            mStudent.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
