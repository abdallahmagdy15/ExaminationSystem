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
    public partial class ManageExam : Form
    {
        public ManageExam()
        {
            InitializeComponent();
        }

        private void ManageExam_Load(object sender, EventArgs e)
        {
            string select = "select Crs_Id from Course";


            try
            {
                sqlCommand1.CommandText = select;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    cmBoxCrsId.Items.Add(dReader[0]);
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("The connection is not stable ");
                return;
            }
        }

        private void cmBoxExId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmBoxCrsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxExId.Items.Clear();
            string select = $@"select Ex_Id from Exam where Crs_Id =  {cmBoxCrsId.SelectedItem.ToString()} ";


            try
            {
                sqlCommand1.CommandText = select;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    cmBoxExId.Items.Add(dReader["Ex_Id"]);
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("The connection is not stable ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string Delete = "deleteExam @id";
                sqlCommand1.Parameters.AddWithValue("@id", cmBoxExId.SelectedItem.ToString());
                sqlCommand1.CommandText = Delete;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(" Question Deleted");
               // txtQnContent.Text = txtQnGrade.Text = txtChId.Text = txtChContent.Text = txtAnswer.Text = string.Empty;
                cmBoxExId.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw (ex);
            }
        }
    }
}
