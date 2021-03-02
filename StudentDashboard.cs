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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            SetupExam();
        }
        void SetupExam()
        {
            //get current exam on this date 
            LoginForm.sqlCommand1.CommandText = "GetCurrentRandExam @St_Id";
            LoginForm.sqlCommand1.Parameters.AddWithValue("@St_Id", LoginForm.CurrentStudent.StId);
            LoginForm.sqlConnection1.Open();
            SqlDataReader dr=null;
            try
            {
                dr = LoginForm.sqlCommand1.ExecuteReader();
                if (dr.Read())
                {
                    noExamsLabel.Visible = false;
                    mainPanel.Visible = true;
                    //Fill Header of Exam
                    stNameLabel.Text = stNameLabel.Text + LoginForm.CurrentStudent.FullName;
                    deptLabel.Text = deptLabel.Text + LoginForm.CurrentStudent.DeparmentName;
                    exDescLabel.Text = exDescLabel.Text + dr.GetString(1);
                    durationLabel.Text = durationLabel.Text + dr.GetInt32(2);
                    crsLabel.Text = crsLabel.Text + dr.GetString(3);
                    dateLabel.Text= dateLabel.Text +
                        DateTime.UtcNow.ToString("MM-dd-yyyy");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                dr.Close();
                LoginForm.sqlConnection1.Close();
                LoginForm.sqlCommand1.Parameters.Clear();
            }

        }
    }
}
