﻿using System;
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
                int choiceCounter = 3;
                int questionCounter = 0;
                while (dr.Read())
                {
                    exam.Questions[questionCounter].Choices.Add(
                        new Choice() { Id = dr.GetInt32(0), Content = dr.GetString(1) }
                        );
                    //set 4 choices for each question
                    if (choiceCounter != 0)
                        choiceCounter--;
                    else
                    {
                        choiceCounter = 3;
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
            ShowQuestionsWithChoices();
        }

        void ShowQuestionsWithChoices()
        {
            int qnY = 102,chY= 155;
            exam.Questions.ForEach(qn =>
            {
                //generate question label
                Label qnLabel = new Label();
                qnLabel.Location = new System.Drawing.Point(11, qnY);
                qnLabel.Name = "Qn" + qn.Id;
                qnLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
                qnLabel.Size = new System.Drawing.Size(1005, 50);
                qnLabel.TabIndex = 1;
                qnLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
                qnLabel.Text = qn.Content;
                this.mainPanel.Controls.Add(qnLabel);

                //generate group box for choices 
                GroupBox group = new GroupBox();
                group.Location = new System.Drawing.Point(11, qnY+ 50);
                group.Name = "groupBox"+qn.Id;
                group.Size = new System.Drawing.Size(1005, 116);
                group.TabIndex = 1;
                group.TabStop = false;
                this.mainPanel.Controls.Add(group);

                //generate choices
                chY =  0;
                qn.Choices.ForEach(ch =>
                {
                    RadioButton chRadioBtn = new RadioButton();
                    chRadioBtn.Location = new System.Drawing.Point(11, chY);
                    chRadioBtn.Name = "Ch"+ch.Id;
                    chRadioBtn.Size = new System.Drawing.Size(1005, 24);
                    chRadioBtn.TabIndex = 2;
                    chRadioBtn.TabStop = true;
                    chRadioBtn.Text = ch.Content;
                    chRadioBtn.Font = new System.Drawing.Font("Tahoma", 12F);
                    chRadioBtn.UseVisualStyleBackColor = true;
                    chY += 30;
                    group.Controls.Add(chRadioBtn);
                });

                //generate horizontal divider
                Label divider = new Label();
                divider.Location = new System.Drawing.Point(11, qnY+170);
                divider.Name = "divider"+ qn.Id;
                divider.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
                divider.Size = new System.Drawing.Size(1005, 30);
                divider.BackColor = System.Drawing.Color.WhiteSmoke;

                divider.TabIndex = 1;
                divider.Text = "";
                this.mainPanel.Controls.Add(divider);

                qnY += 200;
            });

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
