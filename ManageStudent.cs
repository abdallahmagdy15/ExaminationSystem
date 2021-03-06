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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void mangeStudent_Load(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminDashboard admin = new AdminDashboard();
            admin.ShowDialog();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Id = txtSid.Text;
            string fName = txtFName.Text;
            string lName = txtlname.Text;
            string BD = txtStBd.Text;
            string Did = BoxDepId.Text;
            
            string insert = "insertStudent @id, @fName, @lName, @BD, @Did";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@id", Id);
                sqlCommand1.Parameters.AddWithValue("@fName", fName);
                sqlCommand1.Parameters.AddWithValue("@lName", lName);
                sqlCommand1.Parameters.AddWithValue("@BD", BD);
                sqlCommand1.Parameters.AddWithValue("@Did", Did);
                sqlCommand1.CommandText = insert;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " Student Added");
                Id = fName = lName = BD = Did = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            int flag = 0;
            int id=0;
            try
            {
                
                 id = int.Parse(txtSid.Text); 
                string FindStudent = "GetSTudentData_byID @id";
                sqlCommand1.Parameters.AddWithValue("@id", id);
                sqlCommand1.CommandText = FindStudent;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();
               
                while (dReader.Read())
                {
                    flag = 1;
                    BoxDepId.Text = dReader["Dept_Id"].ToString();
                    txtStBd.Text = dReader["St_BD"].ToString();
                    txtSid.Text = dReader["St_Id"].ToString();
                    txtlname.Text = dReader["St_Lname"].ToString();
                    txtFName.Text = dReader["St_Fname"].ToString();
                }
                if (flag == 0) { MessageBox.Show("this Id " + id + " Not exist"); }
                dReader.Close();
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
            }
            catch(System.NullReferenceException ex)
            {
                MessageBox.Show("this Id " + id + " Not exist");
            }
            
        }

        private void BoxDepId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            string Id = txtSid.Text;
            string fName = txtFName.Text;
            string lName = txtlname.Text;
            string BD = txtStBd.Text;
            string Did = BoxDepId.Text;

            string Update = "updateStudent @id,@fName,@lName,@BD,@Did";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@id", Id);
                sqlCommand1.Parameters.AddWithValue("@fName", fName);
                sqlCommand1.Parameters.AddWithValue("@lName", lName);
                sqlCommand1.Parameters.AddWithValue("@BD", BD);
                sqlCommand1.Parameters.AddWithValue("@Did", Did);
                sqlCommand1.CommandText = Update;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " Student updated");
                Id = fName = lName = BD = Did = string.Empty;

            }
            catch
            {
                MessageBox.Show("Error");

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtSid.Text;

            string DeleteStudent = "DeleteStById @id";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@id", id);

                sqlCommand1.CommandText = DeleteStudent;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " Student Deleted");
                id = string.Empty;

            }
            catch
            {
                MessageBox.Show("Error");

            }
        }
    }
}
