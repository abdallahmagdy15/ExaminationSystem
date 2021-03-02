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
        Exam exam;
        public StudentDashboard()
        {
            InitializeComponent();
            SetupExamInfo();
            SetupExamQuestions();
        }
        void SetupExamInfo()
        {
            //get current exam on this date 
            LoginForm.sqlCommand1.CommandText = "GetCurrentRandExam @St_Id";
            LoginForm.sqlCommand1.Parameters.AddWithValue("@St_Id", LoginForm.CurrentStudent.StId);
            LoginForm.sqlConnection1.Open();
            SqlDataReader dr = null;
            try
            {
                dr = LoginForm.sqlCommand1.ExecuteReader();
                if (dr.Read())
                {
                    //initialize exam obj 
                    exam = new Exam() { Ex_Id = dr.GetInt32(0), Ex_Desc = dr.GetString(1), Ex_Duration = dr.GetInt32(2), Crs_Name = dr.GetString(3) };
                    noExamsLabel.Visible = false;
                    mainPanel.Visible = true;
                    //Fill Header of Exam
                    stNameLabel.Text = stNameLabel.Text + LoginForm.CurrentStudent.FullName;
                    deptLabel.Text = deptLabel.Text + LoginForm.CurrentStudent.DeparmentName;
                    exDescLabel.Text = exDescLabel.Text + exam.Ex_Desc;
                    durationLabel.Text = durationLabel.Text + exam.Ex_Duration;
                    crsLabel.Text = crsLabel.Text + dr.GetString(3);
                    dateLabel.Text = dateLabel.Text +
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

        void SetupExamQuestions()
        {
            //get exam questions
            LoginForm.sqlCommand1.CommandText = "[Get_ExamQuestions_by_ExamID] @Ex_Id";
            LoginForm.sqlCommand1.Parameters.AddWithValue("@Ex_Id", exam.Ex_Id);
            SqlDataReader dr;
            try
            {
                LoginForm.sqlConnection1.Open();
                dr = LoginForm.sqlCommand1.ExecuteReader();
                while (dr.Read())
                {
                    Question q = new Question()
                    {
                        Id = dr.GetInt32(0),
                        Content = dr.GetString(1),
                        Grade = dr.GetInt32(2),
                        Type = dr.GetBoolean(3)
                    };
                    exam.Questions.Add(q);
                }

                dr.Close();
                //filling questions with choices
                //MAIN TASK : PASSING ARRAY OF QUESTIONS IDs TO QUERY TO GET ALL CHOICES AT ONCE

                DataTable dt = new DataTable();
                dt.Columns.Add("Ch_Id", typeof(int));
                exam.Questions.ForEach(q =>
                {
                    dt.Rows.Add(q.Id);
                });

                LoginForm.sqlCommand1.CommandText = "[GETQUESTIONS_CHOICES] @QnIdsList";
                // mapping the C# DataTable object to the correct SQL User Defined Type
                SqlParameter param = LoginForm.sqlCommand1.Parameters.AddWithValue("@QnIdsList", dt);
                param.SqlDbType = SqlDbType.Structured;
                param.TypeName = "QnIdsList";

                dr = LoginForm.sqlCommand1.ExecuteReader();
                //reading all choices of all questions
                int choiceCounter = 4;
                int questionCounter = 0;
                while (dr.Read())
                {
                    exam.Questions[questionCounter].Choices.Add(
                        new Choice() { Id=dr.GetInt32(0),Content=dr.GetString(1) }
                        );
                    //set 4 choices for each question
                    if (choiceCounter != 0)
                        choiceCounter--;
                    else
                    {
                        choiceCounter = 4;
                        questionCounter++;
                    }

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            // rendering the questions and choices
            //RenderQuestionsWithChoices();
        }

    }
}
