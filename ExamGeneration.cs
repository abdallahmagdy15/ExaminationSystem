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
    public partial class ExamGeneration : Form
    {
        public ExamGeneration()
        {
            InitializeComponent();
        }

        public void onLoadForm()
        {
            string selectstm = "SELECT Crs_Id, Crs_Name FROM Course";
            sqlCommand1.CommandText = selectstm;
            SqlDataReader sdReader;
            sqlConnection1.Open();
            sdReader = sqlCommand1.ExecuteReader();
            while (sdReader.Read())
            {
                comboBox1.Items.Add(sdReader[1]);
            }
            sdReader.Close();
            sqlConnection1.Close();
        }

        int CourseId;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseName = comboBox1.SelectedItem.ToString();
            string querycomm = "SELECT Crs_Id FROM Course WHERE Crs_Name " + courseName;
            sqlCommand1.CommandText = querycomm;
            sqlConnection1.Open();
            SqlDataReader sdReader;
            sdReader = sqlCommand1.ExecuteReader();

            while (sdReader.Read())
            {
                CourseId = Convert.ToInt32(sdReader[0].ToString());
            }
            sdReader.Close();
            sqlConnection1.Close();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string exDesc = textBox1.Text;
            int exDuration = (int)(numericUpDown1.Value);
            int MCQ_QNum = int.Parse(textBox2.Text);
            int TF_QNum = int.Parse(textBox3.Text);

            try
            {
                sqlConnection1.Open();

                SqlCommand command = new SqlCommand("generateExam", sqlConnection1);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CourseId", SqlDbType.Int).Value = CourseId;
                command.Parameters.AddWithValue("@Ex_Desc", SqlDbType.NVarChar).Value = exDesc;
                command.Parameters.AddWithValue("@N_MCQ", SqlDbType.Int).Value = MCQ_QNum;
                command.Parameters.AddWithValue("@N_TF", SqlDbType.Int).Value = TF_QNum;
                command.Parameters.AddWithValue("@Duration", SqlDbType.Int).Value = exDuration;

                int AffectedRows = command.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("New Exam Generated Successfully");
                textBox1.Text = string.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error In Generating New Exam As" + exception.Message);
            }
            
        }

    }
}
