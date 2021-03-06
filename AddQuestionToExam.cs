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
    public partial class AddQuestionToExam : Form
    {
        string CrsId;
        string ExId;
        
        public AddQuestionToExam(string _crsId , string _exId)
        {
            InitializeComponent();
            this.CrsId = _crsId;
            this.ExId = _exId;

        }

        private void AddQuestionToExam_Load(object sender, EventArgs e)
        {
            string select = $@"select Qn_Id from Question where Crs_Id = {this.CrsId}";


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //insert into Ex_Qn(Ex_Id , Qn_Id) values(1000 ,1000)
            if(cmBoxQnId.Text == "" || cmBoxQnId.SelectedItem == null)
            {
                MessageBox.Show("select Question");
                return;
            }
            if(txtQnContent.Text == "")
            {
                MessageBox.Show("the content is Empty");
                return;
            }
            string insert = $@"insert into Ex_Qn(Ex_Id , Qn_Id) values({this.ExId} ,{cmBoxQnId.SelectedItem.ToString()})";
            try
            {
                
                sqlCommand1.CommandText = insert;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " Question Added");
                txtQnContent.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmBoxCrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = $@"select * from Question where Qn_Id = {cmBoxQnId.SelectedItem.ToString()}";


            try
            {
                sqlCommand1.CommandText = select;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    txtQnContent.Text =dReader["Qn_Content"].ToString();
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("The connection is not stable ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageExam Ex = new ManageExam();
            Ex.ShowDialog();
        }
    }
}
