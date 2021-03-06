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
    public partial class McqQuestion : Form
    {
        public McqQuestion()
        {
            InitializeComponent();
        }

        private void McqQuestion_Load(object sender, EventArgs e)
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

        private void cmBoxQnId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Qn_Id = cmBoxQnId.Text;
            int flage = 0;
            
            try
            {
                string selectQn = $@"select * from Question q , Choice ch where q.Qn_Id = {Qn_Id} and q.Qn_Type = 'True' and ch.Qn_Id = {Qn_Id} ";
                sqlCommand1.CommandText = selectQn;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    flage = 1;
                    txtQnContent.Text = dReader["Qn_Content"].ToString();
                    txtQnGrade.Text = dReader["Qn_Grade"].ToString();
                    txtAnswer.Text = dReader["Qn_Answer"].ToString();
                    Choice ch = new Choice() { Id = (int)dReader["Ch_Id"] , Content = (string)dReader["Ch_Content"] };
                    ChoiceList.Items.Add(ch);
                    ChoiceList.Items.Add("\n");
                }
                if(flage == 0)
                {
                    MessageBox.Show("question not found");
                    return;
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
        }

        private void cmBoxCrsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxQnId.Items.Clear();
            txtAnswer.Text = txtQnContent.Text = txtQnGrade.Text = txtChContent.Text = txtChId.Text = string.Empty;
            ChoiceList.Items.Clear();
            string select = $@"select Qn_Id from Question where Crs_Id = {cmBoxCrsId.SelectedItem.ToString()} and Qn_Type = 'True'";


            try
            {
                sqlCommand1.CommandText = select;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    cmBoxQnId.Items.Add(dReader["Qn_Id"]);
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("The connection is not stable ");
            }
        }

        private void ChoiceList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Choice Choice = ChoiceList.SelectedItem as Choice;
            string QnId = cmBoxQnId.Text;
            try
            {
                string select = $@"select Ch_Id , Ch_Content from Choice where Ch_Id  = {Choice.Id} and Qn_Id = {QnId}";
                sqlCommand1.CommandText = select;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    txtChId.Text =  dReader["Ch_Id"].ToString();
                    txtChContent.Text =  dReader["Ch_Content"].ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmBoxQnId.Text == "" || cmBoxQnId.SelectedItem ==null)
            {
                MessageBox.Show("enter Question ID");
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
                txtQnContent.Text = txtQnGrade.Text = txtChId.Text = txtChContent.Text = txtAnswer.Text = string.Empty;
                cmBoxQnId.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw (ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            McqAdd Qn = new McqAdd();
            Qn.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageQuestion Qn = new ManageQuestion();
            Qn.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmBoxCrsId.SelectedItem == null)
            {
                MessageBox.Show("select course");
                return;
            }
            if (txtQnContent.Text == "" || txtQnGrade.Text == "" || cmBoxQnId.SelectedItem == null || cmBoxQnId.Text == "")
            {
                MessageBox.Show("fill the fields first");
                return;
            }
            sqlConnection1.Close();

            string QnId = cmBoxQnId.Text;
            try
            {
                string Edit = $"updateQuestion @Qid ,@Qcont ,@Qgrade , @Cid ,@Qans ";
                sqlCommand1.Parameters.AddWithValue("@Qid", QnId);
                sqlCommand1.Parameters.AddWithValue("@Qcont", txtQnContent.Text);
                sqlCommand1.Parameters.AddWithValue("@Qgrade", txtQnGrade.Text);
                sqlCommand1.Parameters.AddWithValue("@Cid", cmBoxCrsId.Text);
                sqlCommand1.Parameters.AddWithValue("@Qans", txtAnswer.Text);
                sqlCommand1.CommandText = Edit;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();

                MessageBox.Show(" Question updated");
                txtQnContent.Text = txtQnGrade.Text = txtChId.Text = txtChContent.Text = txtAnswer.Text = string.Empty;
                ChoiceList.Items.Clear();
                cmBoxQnId.Text = string.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection1.Close();
                throw (ex);
            }

        }

        private void btnChEdit_Click(object sender, EventArgs e)
        {

            string QnId = cmBoxQnId.Text;
            try
            {
                string selectCh = $@"updateChoiceByID @id ,@Content ,@Qn_id ";
                sqlCommand1.Parameters.AddWithValue("@Qn_id", QnId);
                sqlCommand1.Parameters.AddWithValue("@id", txtChId.Text);
                sqlCommand1.Parameters.AddWithValue("@Content", txtChContent.Text);
                sqlCommand1.CommandText = selectCh;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " choice updated");
                ChoiceList.Items.Clear();
            
                txtChId.Text = txtChContent.Text = string.Empty;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection1.Close();
                throw (ex);

            }




            string Qn_Id = cmBoxQnId.Text;


            try
            {
                string selectQn = $@"select * from Question q , Choice ch where q.Qn_Id = {Qn_Id} and q.Qn_Type = 'True' and ch.Qn_Id = {Qn_Id} ";
                sqlCommand1.CommandText = selectQn;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    Choice ch = new Choice() { Id = (int)dReader["Ch_Id"], Content = (string)dReader["Ch_Content"] };
                    ChoiceList.Items.Add(ch);
                    ChoiceList.Items.Add("\n");
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
    }
}
