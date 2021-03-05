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
    public partial class ManageQuestion : Form
    {
        public ManageQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrueOrFalse_Click(object sender, EventArgs e)
        {
            TrueOrFalseQuestion Qn = new TrueOrFalseQuestion();
            this.Visible = false;
            Qn.ShowDialog();
        }

        private void btnMCQ_Click(object sender, EventArgs e)
        {
            McqQuestion Qn = new McqQuestion();
            this.Visible = false;
            Qn.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminDashboard admin = new AdminDashboard();
            admin.ShowDialog();
        }
    }
}
