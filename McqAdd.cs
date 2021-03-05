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
    public partial class McqAdd : Form
    {
        public McqAdd()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            McqQuestion Qn = new McqQuestion();
            Qn.ShowDialog();
        }

        private void McqAdd_Load(object sender, EventArgs e)
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
                    cmBoxCrId.Items.Add(dReader[0]);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "InsertMCQQuestion @Qn_Content ,@Qn_Grade ,@Crs_Id ,@AnswerContent ,@Ch1 ,@Ch2 ,@Ch3 ,@Ch4 ";
                sqlCommand1.Parameters.AddWithValue("@Qn_Content", txtQnContent.Text);
                sqlCommand1.Parameters.AddWithValue("@Qn_Grade", txtQnGrade.Text);
                sqlCommand1.Parameters.AddWithValue("@Crs_Id", cmBoxCrId.SelectedItem.ToString());
                sqlCommand1.Parameters.AddWithValue("@AnswerContent", txtQnAnswer.Text);
                sqlCommand1.Parameters.AddWithValue("@Ch1", txtCh1.Text);
                sqlCommand1.Parameters.AddWithValue("@Ch2", txtCh2.Text);
                sqlCommand1.Parameters.AddWithValue("@Ch3", txtCh3.Text);
                sqlCommand1.Parameters.AddWithValue("@Ch4", txtCh4.Text);
                sqlCommand1.CommandText = insert;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(" Question Added");
                txtQnContent.Text = txtQnGrade.Text =txtCh1.Text = txtCh2.Text = txtCh3.Text = txtCh4.Text = txtQnAnswer.Text = string.Empty;
                
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }
    }
}
