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
            onLoadForm();
        }


        public void onLoadForm()
        {
            string selectstm = "SELECT * FROM Course";
            LoginForm.sqlCommand1.CommandText = selectstm;
            SqlDataReader sdReader;
            try
            {
                LoginForm.sqlConnection1.Open();
                sdReader = LoginForm.sqlCommand1.ExecuteReader();
                while (sdReader.Read())
                {
                    KeyValuePair<int, string> crs = new KeyValuePair<int, string>(sdReader.GetInt32(0), sdReader.GetString(1));
                    comboBox1.Items.Add(crs);
                }
                sdReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                LoginForm.sqlConnection1.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    string querycomm = "SELECT Crs_Id FROM Course WHERE Crs_Id " + course.Key;
            //    sqlCommand1.CommandText = querycomm;
            //    sqlConnection1.Open();
            //    SqlDataReader sdReader;
            //    sdReader = sqlCommand1.ExecuteReader();

            //    while (sdReader.Read())
            //    {
            //        CourseId = Convert.ToInt32(sdReader[0].ToString());
            //    }
            //    sdReader.Close();
            //    sqlConnection1.Close();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Fields can't be empty!");
                return;
            }
            string exDesc = textBox1.Text;
            int exDuration = (int)(numericUpDown1.Value);
            int MCQ_QNum = int.Parse(textBox2.Text);
            int TF_QNum = int.Parse(textBox3.Text);

            try
            {
                LoginForm.sqlConnection1.Open();

                SqlCommand command = new SqlCommand("generateExam", LoginForm.sqlConnection1);
                command.CommandType = CommandType.StoredProcedure;
                KeyValuePair<int, string> course = (KeyValuePair<int, string>)comboBox1.SelectedItem;
                command.Parameters.AddWithValue("@CourseId", SqlDbType.Int).Value = course.Key;
                command.Parameters.AddWithValue("@Ex_Desc", SqlDbType.NVarChar).Value = exDesc;
                command.Parameters.AddWithValue("@N_MCQ", SqlDbType.Int).Value = MCQ_QNum;
                command.Parameters.AddWithValue("@N_TF", SqlDbType.Int).Value = TF_QNum;
                command.Parameters.AddWithValue("@Duration", SqlDbType.Int).Value = exDuration;

                int AffectedRows = command.ExecuteNonQuery();
                LoginForm.sqlConnection1.Close();
                command.Parameters.Clear();
                MessageBox.Show("New Exam Generated Successfully");
                textBox1.Text = string.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error In Generating New Exam As" + exception.Message);
                throw;
            }

        }
        bool isValid()
        {
            return true;
        }


    }
}
