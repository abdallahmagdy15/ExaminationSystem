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
            string ExID = cmBoxExId.SelectedItem.ToString();

            try
            {
                string exam = $@"select * from Exam where Ex_Id = {ExID}";
                sqlCommand1.CommandText = exam;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    txtExDuration.Text = dReader["Ex_Duration"].ToString();
                    txtExDesc.Text = dReader["Ex_Desc"].ToString();
                    txtExDate.Text = dReader["Ex_Date"].ToString();
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection1.Close();
                throw (ex);
            }

            try
            {
                string selectEx = $@"Get_ExamQuestions_by_ExamID @Eid ";
                sqlCommand1.Parameters.Clear();
                sqlCommand1.Parameters.AddWithValue("@Eid", ExID);
                sqlCommand1.CommandText = selectEx;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                   
                    Question Qn = new Question() { Id = (int) dReader["Qn_Id"]  , Content = dReader["Qn_Content"].ToString(), Grade = (int) dReader["Qn_Grade"] , Type =(bool) dReader["Qn_Type"] };
                    ExQnList.Items.Add(Qn);
                    ExQnList.Items.Add("\n");
                    
                }
                dReader.Close();
                sqlConnection1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection1.Close();
                throw (ex);
            }
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
                MessageBox.Show(" Exam Deleted");
               // txtQnContent.Text = txtQnGrade.Text = txtChId.Text = txtChContent.Text = txtAnswer.Text = string.Empty;
                cmBoxExId.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw (ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminDashboard admin = new AdminDashboard();
            admin.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(cmBoxExId.Text == "" || cmBoxExId.SelectedItem == null)
            {
                MessageBox.Show("Select Exam");
                return;
            }
            
            sqlConnection1.Close();

            string ExId = cmBoxExId.SelectedItem.ToString();
            try
            {
                string Edit = $"updateExam @Eid ,@EDate , @EDesc ,  @Ex_Duration ";
                sqlCommand1.Parameters.Clear();
                sqlCommand1.Parameters.AddWithValue("@Eid", ExId);
                sqlCommand1.Parameters.AddWithValue("@EDate", txtExDate.Text);
                sqlCommand1.Parameters.AddWithValue("@EDesc", txtExDesc.Text);
                sqlCommand1.Parameters.AddWithValue("@Ex_Duration", txtExDuration.Text);
                sqlCommand1.CommandText = Edit;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                
                sqlConnection1.Close();

                MessageBox.Show(" Exam updated");
                cmBoxExId.Items.Clear();
                txtExDuration.Text = txtExDesc.Text = txtExDate.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection1.Close();
                throw (ex);
            }
        }

        private void ExQnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question Qn = ExQnList.SelectedItem as Question;
            string ExId = cmBoxExId.Text;
            bool QnType; 
            try
            {
                string selectQn = $@"select q.* from Question q , Ex_Qn e where e.Ex_Id = {ExId} and q.Qn_Id = {Qn.Id} and e.Qn_Id = q.Qn_Id";
                sqlCommand1.CommandText = selectQn;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    txtQnId.Text = dReader["Qn_Id"].ToString();
                    txtQnContent.Text = dReader["Qn_Content"].ToString();
                    QnType = (bool)dReader["Qn_Type"];
                    if (QnType)
                    {
                        txtQnType.Text = "MCQ";
                    }
                    else
                    {
                        txtQnType.Text = @"True / False";
                    }
                }
                

                dReader.Close();
                sqlConnection1.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection1.Close();
                throw (ex);
            }
        }

        private void btnDeleteQn_Click(object sender, EventArgs e)
        {
            string ExId = cmBoxExId.Text;
            try
            {
                string Delete = "deleteExamQuestion @Eid , @Qnid ";
                sqlCommand1.Parameters.Clear();
                sqlCommand1.Parameters.AddWithValue("@Eid", cmBoxExId.SelectedItem.ToString());
                sqlCommand1.Parameters.AddWithValue("@Qnid", txtQnId.Text);
                sqlCommand1.CommandText = Delete;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(" Question Deleted");
                ExQnList.Items.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw (ex);
            }


            //Reload item in list
            try
            {
                string selectEx = $@"Get_ExamQuestions_by_ExamID @Eid ";
                sqlCommand1.Parameters.Clear();
                sqlCommand1.Parameters.AddWithValue("@Eid", ExId);
                sqlCommand1.CommandText = selectEx;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {

                    Question Qn = new Question() { Id = (int)dReader["Qn_Id"], Content = dReader["Qn_Content"].ToString(), Grade = (int)dReader["Qn_Grade"], Type = (bool)dReader["Qn_Type"] };
                    ExQnList.Items.Add(Qn);
                    ExQnList.Items.Add("\n");

                }
                dReader.Close();
                sqlConnection1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw (ex);
            }

        }

        private void btnAddQn_Click(object sender, EventArgs e)
        {
            if(cmBoxCrsId.SelectedItem == null || cmBoxCrsId.Text == "" )
            {
                MessageBox.Show("select course");
                return;
            }
            if (cmBoxExId.SelectedItem == null || cmBoxExId.Text == "")
            {
                MessageBox.Show("select Exam");
                return;
            }


            this.Visible = false;
            AddQuestionToExam ExQn = new AddQuestionToExam(cmBoxCrsId.Text , cmBoxExId.Text);
            ExQn.ShowDialog();
        }
    }
}
