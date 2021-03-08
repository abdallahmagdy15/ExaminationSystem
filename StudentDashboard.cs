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
        HashSet<int> StAnswers = new HashSet<int>();
        public StudentDashboard()
        {
            InitializeComponent();
            StName.Text = LoginForm.CurrentStudent.FullName;
            StDept.Text = LoginForm.CurrentStudent.DeparmentName;
            StBD.Text = LoginForm.CurrentStudent.BirthDate.ToString();
            SetupExamInfo();
            SetupExamsHistory();
        }
        void SetupExamInfo()
        {
            //
            // TODO: check if student already take this exam!!!!!!!!!!!!!!!!!!!
            //
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
                    dr.Close();
                    LoginForm.sqlConnection1.Close();
                    //
                    //
                    SetupExamQuestions();
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
                dt.Columns.Add("Qn_Id", typeof(int));
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
                //4 choices for "multi choice" and 2 choices for "true/false"
                if (exam.Questions.Count > 0)
                    if (exam.Questions[0].Type)
                        choiceCounter = 3;
                    else
                        choiceCounter = 1;
                int questionCounter = 0;
                while (dr.Read())
                {
                    exam.Questions[questionCounter].Choices.Add(
                        new Choice() { Id = dr.GetInt32(0), Content = dr.GetString(1) }
                        );
                    //set choices count for each question
                    if (choiceCounter != 0)
                        choiceCounter--;
                    else
                    {
                        questionCounter++;
                        if (exam.Questions.Count > questionCounter)
                            if (exam.Questions[questionCounter].Type)
                                choiceCounter = 3;
                            else
                                choiceCounter = 1;
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
            int qnY = 102, chY = 155;
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
                //
                //generate group box for choices 
                GroupBox group = new GroupBox();
                group.Location = new System.Drawing.Point(11, qnY + 50);
                group.Name = "groupBox" + qn.Id;
                group.Size = new System.Drawing.Size(1005, 116);
                group.TabIndex = 1;
                group.TabStop = false;
                this.mainPanel.Controls.Add(group);
                //
                //generate choices
                chY = 0;
                qn.Choices.ForEach(ch =>
                {
                    RadioButton chRadioBtn = new RadioButton();
                    chRadioBtn.Location = new System.Drawing.Point(11, chY);
                    chRadioBtn.Name = "Ch" + ch.Id;
                    chRadioBtn.Size = new System.Drawing.Size(1005, 24);
                    chRadioBtn.TabIndex = 2;
                    chRadioBtn.TabStop = true;
                    chRadioBtn.Text = ch.Content;
                    chRadioBtn.Font = new System.Drawing.Font("Tahoma", 12F);
                    chRadioBtn.UseVisualStyleBackColor = true;
                    chY += 30;
                    group.Controls.Add(chRadioBtn);
                });
                //
                //generate horizontal divider
                Label divider = new Label();
                divider.Location = new System.Drawing.Point(11, qnY + 170);
                divider.Name = "divider" + qn.Id;
                divider.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
                divider.Size = new System.Drawing.Size(1005, 30);
                divider.BackColor = System.Drawing.Color.WhiteSmoke;

                divider.TabIndex = 1;
                divider.Text = "";
                this.mainPanel.Controls.Add(divider);

                qnY += 200;
            });
            //end questions loop
            //
            // SubmitBtn
            // 
            Button SubmitBtn = new Button();
            SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            SubmitBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            SubmitBtn.Location = new System.Drawing.Point(875, qnY);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SubmitBtn.Size = new System.Drawing.Size(151, 36);
            SubmitBtn.Margin = new System.Windows.Forms.Padding(10,10,10,50);
            SubmitBtn.TabIndex = 1;
            SubmitBtn.Dock = DockStyle.Bottom;
            SubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SubmitBtn.BackColor = System.Drawing.Color.MidnightBlue;
            SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            this.mainPanel.Controls.Add(SubmitBtn);
        }

        private void SubmitAnswers()
        {
            int questionCounter = 0, choiceId; bool valid = true;
            //looping through groups(questions) of choices
            this.mainPanel.Controls.OfType<GroupBox>().ToList().ForEach(g =>
            {
                //if not all questions answered
                if (!valid)
                    return;

                //submit choice answer to question
                RadioButton choiceRB = g.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (choiceRB == null)
                {
                    MessageBox.Show("Please Answer All Questions!!!");
                    valid = false;
                    return;
                }
                choiceId = int.Parse(choiceRB.Name.Substring(2));
                exam.Questions[questionCounter].Answer =
                exam.Questions[questionCounter].Choices.FirstOrDefault(c => c.Id == choiceId);
                questionCounter++;
            });
            //if all questions not answered
            if (!valid)
                return;
            //
            //saving answers to db and CORRECTING EXAM
            StringBuilder insertingAnswersCommand = new StringBuilder();
            exam.Questions.ForEach(q =>
            {
                insertingAnswersCommand
                .Append($" exec InsertStudentAnswer {LoginForm.CurrentStudent.StId} , {q.Answer.Id} , {q.Id} , {exam.Ex_Id}");
            });
            insertingAnswersCommand.Append($"  exec ExamCorrection {exam.Ex_Id} , {LoginForm.CurrentStudent.StId}");
            LoginForm.sqlCommand1.CommandText = insertingAnswersCommand.ToString();
            try
            {
                LoginForm.sqlConnection1.Open();
                LoginForm.sqlCommand1.ExecuteNonQuery();

                MessageBox.Show("Your Answers Submitted Successfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Your Answers May Not Submitted For Some Reason!\nTry Again Later.");
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                LoginForm.sqlConnection1.Close();
                this.TakeExam.Controls.Remove(this.mainPanel);
                SetupExamsHistory();
            }
        }


        void SetupExamsHistory()
        {
            //get all corrected exams with grades
            LoginForm.sqlCommand1.CommandText = "GetStudentCorrectedExams @StId";
            LoginForm.sqlCommand1.Parameters.AddWithValue("@StId", LoginForm.CurrentStudent.StId);
            SqlDataReader dr;
            try
            {
                LoginForm.sqlConnection1.Open();
                dr = LoginForm.sqlCommand1.ExecuteReader();
                List<StudentGrade> StGradesList = new List<StudentGrade>();
                while (dr.Read())
                {
                    StGradesList.Add(new StudentGrade(dr.GetString(0), dr.GetInt32(1),
                        dr.GetDateTime(2), dr.GetString(3), dr.GetInt32(4), dr.GetInt32(5)));
                }
                ShowStudentGrades(StGradesList);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }

        }

        void ShowStudentGrades(List<StudentGrade> StGradesList)
        {
            int pY = 11;
            StGradesList.ForEach(g =>
            {
                // 
                // Generating components
                // 
                Panel panel = new Panel();
                Label descLabel = new Label();
                Label durationLabel = new Label();
                Label dateLabel = new Label();
                Label crsLabel = new Label();
                Label gradeLabel = new Label();
                this.historyPanel.Controls.Add(panel);

                panel.Anchor = System.Windows.Forms.AnchorStyles.None;
                panel.BackColor = System.Drawing.Color.WhiteSmoke;
                panel.Controls.Add(descLabel);
                panel.Controls.Add(durationLabel);
                panel.Controls.Add(dateLabel);
                panel.Controls.Add(crsLabel);
                panel.Controls.Add(gradeLabel);
                panel.Location = new System.Drawing.Point(11, pY);
                panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
                //panel.Name = "panel2";
                panel.Size = new System.Drawing.Size(1016, 100);
                panel.TabIndex = 1;
                //
                // 
                dateLabel.AutoSize = true;
                dateLabel.Font = new System.Drawing.Font("Tahoma", 12F);
                dateLabel.Location = new System.Drawing.Point(410, pY + 38);
                dateLabel.Name = "dateLabel" + g.ExId;
                dateLabel.Size = new System.Drawing.Size(57, 19);
                dateLabel.TabIndex = 6;
                dateLabel.Text = "Date : " + g.ExDate.ToString();
                // 
                // 
                crsLabel.AutoSize = true;
                crsLabel.Font = new System.Drawing.Font("Tahoma", 12F);
                crsLabel.Location = new System.Drawing.Point(410, pY + 19);
                crsLabel.Name = "crsLabel" + g.ExId;
                crsLabel.Size = new System.Drawing.Size(74, 19);
                crsLabel.TabIndex = 4;
                crsLabel.Text = "Course : " + g.CrsName;
                // 
                // 
                durationLabel.AutoSize = true;
                durationLabel.Font = new System.Drawing.Font("Tahoma", 12F);
                durationLabel.Location = new System.Drawing.Point(30, pY + 38);
                durationLabel.Name = "durationLabel" + g.ExId;
                durationLabel.Size = new System.Drawing.Size(130, 19);
                durationLabel.TabIndex = 3;
                durationLabel.Text = "Exam Duration : " + g.ExDuration;
                // 
                // 
                descLabel.AutoSize = true;
                descLabel.Font = new System.Drawing.Font("Tahoma", 12F);
                descLabel.Location = new System.Drawing.Point(30, pY + 19);
                descLabel.Name = "descLabel" + g.ExId;
                descLabel.Size = new System.Drawing.Size(148, 19);
                descLabel.TabIndex = 2;
                descLabel.Text = "Exam Description : " + g.ExDesc;
                // 
                // 
                gradeLabel.AutoSize = true;
                gradeLabel.Font = new System.Drawing.Font("Tahoma", 12F);
                gradeLabel.Location = new System.Drawing.Point(716, pY + 19);
                gradeLabel.Name = "gradeLabel" + g.ExId;
                gradeLabel.Size = new System.Drawing.Size(67, 19);
                gradeLabel.TabIndex = 7;
                gradeLabel.Text = "Grade : " + g.Grade;
                //

            });
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to submit all of your answers??",
                                     "Submit Exam Answers",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                SubmitAnswers();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            accountCard.Visible = !accountCard.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
