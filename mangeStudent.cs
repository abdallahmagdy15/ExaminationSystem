using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class mangeStudent : Form
    {
        public mangeStudent()
        {
            InitializeComponent();
        }

        private void mangeStudent_Load(object sender, EventArgs e)
        {
            string loadDepartment = "SELECT Dept_Id FROM Department";
            try
            {
                sqlCommand1.CommandText = loadDepartment;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    BoxDepId.Items.Add(dReader[0]);
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("The connection us not stable ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminDashboard admin = new adminDashboard();
            admin.ShowDialog();
            //this.Close();
        }
    }
}
