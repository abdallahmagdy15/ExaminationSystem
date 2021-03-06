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
    public partial class ManageInstructor : Form
    {
        public ManageInstructor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();

            // this.Visible = false;
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void ManageInstructor_Load(object sender, EventArgs e)
        {
            string loadDepartment = "SELECT Dept_Id FROM Department";
            try
            {
                sqlCommand1.CommandText = loadDepartment;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
                while (dReader.Read())
                {
                    BoxDepId.Items.Add(dReader[0]);
                }
                dReader.Close();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("The connection us not stable ");
            }
        }

        private void getDeptId()
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string Id = txtInsId.Text;
            string Name = txtName.Text;
            string Did = BoxDepId.Text;

            string insert = "InsertInstructor @Dept_Id, @Ins_Name";
            try
            {

                sqlCommand1.Parameters.AddWithValue("@Dept_Id", Did);
                sqlCommand1.Parameters.AddWithValue("@Ins_Name", Name);
              //  sqlCommand1.Parameters.AddWithValue("@Did",Id );

                
                sqlCommand1.CommandText = insert;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
                MessageBox.Show(AffectedRows + " instructor inserted");
                 Name = Did = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Id = txtInsId.Text;
            string Name = txtName.Text;
            string Did = BoxDepId.Text;

            string Update = "updateIns @id,@name,@Did";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@id", Id);
                sqlCommand1.Parameters.AddWithValue("@name", Name);
                sqlCommand1.Parameters.AddWithValue("@Did", Did);
                sqlCommand1.CommandText = Update;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
                MessageBox.Show(AffectedRows + " instructor updated");
                Id = Name = Did = string.Empty;

            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int id = 0;
            try
            {

                id = int.Parse(txtInsId.Text);
                string FindStudent = "GetInstructorData_byID @id";
                sqlCommand1.Parameters.AddWithValue("@id", id);
                sqlCommand1.CommandText = FindStudent;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();

                while (dReader.Read())
                {
                    flag = 1;
                    BoxDepId.Text = dReader["Dept_Id"].ToString();
                    txtInsId.Text = dReader["Inst_Id"].ToString();
                    txtName.Text = dReader["Ins_Name"].ToString();
                   
                }
                if (flag == 0) { MessageBox.Show("this Id " + id + " Not exist"); }
                dReader.Close();
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("this Id " + id + " Not exist");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtInsId.Text;

            string DeleteStudent = "DeleteInsById @id";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@id", id);

                sqlCommand1.CommandText = DeleteStudent;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
               MessageBox.Show(AffectedRows + " Instructor Deleted");
                id = string.Empty;

            }
            catch
            {
                MessageBox.Show("Error");

            }
        }
    }
}
