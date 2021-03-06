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
    public partial class TrueOrFalseQuestion : Form
    {
        public TrueOrFalseQuestion()
        {
            InitializeComponent();
        }

        private void TrueOrFalseQuestion_Load(object sender, EventArgs e)
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
            }

            cmBoxAnswer.Items.Add("True");
            cmBoxAnswer.Items.Add("False");
        }

        private void cmBoxCrsId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cmBoxQnId.Items.Clear();
            string selectQn = $@"select Qn_Id from Question where Crs_Id =  {cmBoxCrsId.SelectedItem.ToString()} and Question.Qn_Type = 'False'";

            try
            {
                sqlCommand1.CommandText = selectQn;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    cmBoxQnId.Items.Add(dReader["Ex_Id"]);
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The connection is not stable ");
                throw (ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmBoxQnId.SelectedItem == null)
            {
                MessageBox.Show("need Question Id");
                return;
            }
            try
            {
                string Delete = "deleteQuestion @id";
                sqlCommand1.Parameters.Clear();
                sqlCommand1.Parameters.AddWithValue("@id", cmBoxQnId.SelectedItem.ToString());
                sqlCommand1.CommandText = Delete;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(" Question Deleted");
                txtQnContent.Text = txtQnGrade.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw (ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate Null
            if (cmBoxCrsId.SelectedItem == null )
            {
                MessageBox.Show("select course");
                return;
            }


            
            if (txtQnContent == null  || txtQnGrade == null || cmBoxAnswer.SelectedItem == null)
            {
                MessageBox.Show("need Content and grade and Answer");
                return;
            }


            try
            {
                string insert = "InsertTrueOrFalseQuestion  @Qn_Content	, @Qn_Grade ,@Crs_Id , @AnswerContent ";
                sqlCommand1.Parameters.Clear();
                sqlCommand1.Parameters.AddWithValue("@Qn_Content", txtQnContent.Text);
                sqlCommand1.Parameters.AddWithValue("@Qn_Grade", txtQnGrade.Text);
                sqlCommand1.Parameters.AddWithValue("@Crs_Id", cmBoxCrsId.SelectedItem.ToString());
                sqlCommand1.Parameters.AddWithValue("@AnswerContent", cmBoxAnswer.SelectedItem.ToString());
                sqlCommand1.CommandText = insert;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(" Question Added");
                txtQnContent.Text = txtQnGrade.Text =  string.Empty;
                cmBoxQnId.Items.Clear();
                cmBoxAnswer.Items.Clear();
                cmBoxAnswer.Items.Add("True");
                cmBoxAnswer.Items.Add("False");

                //reload Question Id
                string selectQn = $@"select Qn_Id from Question q where q.Qn_Type = 'False' and q.Crs_Id = {cmBoxCrsId.SelectedItem.ToString()}";
                try
                {
                    sqlCommand1.CommandText = selectQn;
                    SqlDataReader dReader;
                    sqlConnection1.Open();
                    dReader = sqlCommand1.ExecuteReader();
                    while (dReader.Read())
                    {
                        cmBoxQnId.Items.Add(dReader[0]);
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
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if ( cmBoxQnId.SelectedItem != null || cmBoxQnId.Text != "")
            {

                sqlConnection1.Close();
                string QnId = cmBoxQnId.Text;
                cmBoxAnswer.Items.Clear();
                cmBoxCrsId.Items.Clear();
                int flag = 0;
                try
                {
                    string select = $"searchTrueOrFalseQuestion @Qid";
                    sqlCommand1.Parameters.Clear();
                    sqlCommand1.Parameters.AddWithValue("@Qid", QnId);

                    sqlCommand1.CommandText = select;
                    sqlConnection1.Open();
                    SqlDataReader dr = sqlCommand1.ExecuteReader();
                    while (dr.Read())
                    {
                        flag = 1;
                        txtQnContent.Text = dr["Qn_Content"].ToString();
                        txtQnGrade.Text = dr["Qn_Grade"].ToString();
                        cmBoxAnswer.Items.Add(dr["Ch_Content"].ToString());
                        cmBoxCrsId.Items.Add(dr["Crs_Id"].ToString());
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("this Id " + QnId + " Not exist");
                        return;
                    }

                    dr.Close();
                    sqlConnection1.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                    throw (ex);

                }
            }
            else
            {
                MessageBox.Show("enter question ID");
                return;
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //validate Null

            if (cmBoxCrsId.SelectedItem == null)
            {
                MessageBox.Show("select course");
                return;
            }
            if (cmBoxQnId.SelectedItem != null || cmBoxQnId.Text != "")
            {
                if (txtQnContent.Text == "" || txtQnGrade.Text == "" || cmBoxAnswer.SelectedItem == null)
                {
                    MessageBox.Show("need Content and grade and Answer");
                    return;
                }
                else
                {
                    sqlConnection1.Close();
                    string QnId = cmBoxQnId.Text;
                    cmBoxAnswer.Items.Clear();
                    cmBoxCrsId.Items.Clear();
                    int flag = 0;
                    try
                    {
                        string Edit = $"updateTrueOrFalseQuestion @Qnid ,@Qcont ,@Qgrade ,@Cid ,@Qans";
                        sqlCommand1.Parameters.AddWithValue("@Qnid", QnId);
                        sqlCommand1.Parameters.AddWithValue("@Qcont", txtQnContent.Text);
                        sqlCommand1.Parameters.AddWithValue("@Qgrade", txtQnGrade.Text);
                        sqlCommand1.Parameters.AddWithValue("@Cid", cmBoxCrsId.Text);
                        sqlCommand1.Parameters.AddWithValue("@Qans", cmBoxAnswer.Text);
                        sqlCommand1.CommandText = Edit;

                        sqlConnection1.Open();
                        sqlCommand1.ExecuteNonQuery();
                        sqlConnection1.Close();
                        MessageBox.Show(" Question updated");
                        txtQnContent.Text = txtQnGrade.Text = string.Empty;
                        cmBoxAnswer.Text = string.Empty;
                        cmBoxCrsId.Text = string.Empty;
                        cmBoxQnId.Text = string.Empty;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnection1.Close();
                        throw (ex);
                    }
                }


                
            }
            else
            {
                MessageBox.Show("select Question");
                return;
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageQuestion Qn = new ManageQuestion();
            Qn.ShowDialog();
        }
    }
}
