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
    public partial class ManageCourse : Form
    {
        public ManageCourse()
        {
            InitializeComponent();
        }
        Dictionary<int, string> InsDic = new Dictionary<int, string>();
        int insId;


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
         
        private void ManageCourse_Load(object sender, EventArgs e)
        {
            try
            {
                LoginForm.sqlConnection1.Open();
               // sqlConnection1.Open();
                SqlCommand crs = new SqlCommand("GET_ALL_COURSES", LoginForm.sqlConnection1);
                crs.CommandType = CommandType.StoredProcedure;
                SqlDataReader Crs = crs.ExecuteReader();
                while (Crs.Read())
                {
                    
                    BoxCrsId.Items.Add(Crs["Crs_Id"].ToString());
                    

                }
                Crs.Close();


            }
            catch
            {
                MessageBox.Show(" No Course To Show ");
                throw;
            }
            finally
            {
                LoginForm.sqlConnection1.Close();
                
            }

              getcourse();
            GetCourseIns();

        }

        private void getcourse()
        {
            try
            {
                LoginForm.sqlConnection1.Open();
                SqlCommand std = new SqlCommand("GET_ALL_COURSES", LoginForm.sqlConnection1);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(std.ExecuteReader());
                dataGridView1.DataSource = dt;
                LoginForm.sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();

            // this.Visible = false;
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }
        private void GetCourseIns()
        {
            try
            {
                LoginForm.sqlConnection1.Open();
                SqlCommand std = new SqlCommand("GET_ALL_Ins", LoginForm.sqlConnection1);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    InsDic.Add(int.Parse(Std["Inst_Id"].ToString()), Std["Ins_Name"].ToString());
                    cmbInsName.Items.Add(Std["Ins_Name"]).ToString();
                }
                Std.Close();
                LoginForm.sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Data ");
                throw;
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtCrsName.Text == "" || txtCrsName.Text == null) 
                { MessageBox.Show(" Please Enter Data "); }
                else
                {
                    LoginForm.sqlConnection1.Open();
                    SqlCommand cmd = new SqlCommand("addCourse", LoginForm.sqlConnection1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@crsname", SqlDbType.NVarChar).Value = txtCrsName.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@insId", SqlDbType.Int).Value = insId;
                    int x = cmd.ExecuteNonQuery();
                    if (x == -1)
                    {
                        MessageBox.Show(" course is  existed ");
                    }
                    else
                    {
                        MessageBox.Show("You Added New Course ");
                    }

                    LoginForm.sqlConnection1.Close();
                    txtCrsName.Text = String.Empty;
                }
        }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            // GetCourseIns();
            getcourse();

}

        private void cmbInsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in InsDic)
            {
                if (cmbInsName.SelectedItem.ToString() == item.Value)
                {
                    insId = item.Key;
                    break;
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
               
            //        LoginForm.sqlConnection1.Open();
            //    //getCourseById must required
            //         SqlCommand cmd = new SqlCommand("getCrsByIdandIns", LoginForm.sqlConnection1);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = int.Parse(BoxCrsId.SelectedItem.ToString());
            //        SqlDataReader Std = cmd.ExecuteReader();
            //        while (Std.Read())
            //        {
            //           // InsDic.Add(int.Parse(Std["Inst_Id"].ToString()), Std["Ins_Name"].ToString());
            //            cmbInsName.SelectedItem=(Std["Ins_Name"]).ToString();
            //            txtCrsName.Text = Std["Crs_Name"].ToString();
            //       // MessageBox.Show(Std["Crs_Name"].ToString());
            //        }
            //        Std.Close();
            //        LoginForm.sqlConnection1.Close();

            //      //  txtCrsName.Text = String.Empty;
                
            //}
            //catch
            //{
            //    MessageBox.Show(" Please Enter Valid Data ");
            //    throw;
            //}
            
              try
            {
                LoginForm.sqlConnection1.Open();
                SqlCommand std = new SqlCommand("getCrsByIdandIns", LoginForm.sqlConnection1);

                std.CommandType = CommandType.StoredProcedure;
                std.Parameters.AddWithValue("@id", SqlDbType.Int).Value = insId;
                DataTable dt = new DataTable();
                dt.Load(std.ExecuteReader());
                dataGridView2.DataSource = dt;
                LoginForm.sqlConnection1.Close();
                std.Parameters.Clear();
            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
             
            // Get
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                LoginForm.sqlConnection1.Open();
                //DeleteCourseById must required
                SqlCommand cmd = new SqlCommand("DeleteCrsById", LoginForm.sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = int.Parse(BoxCrsId.SelectedItem.ToString());
                SqlDataReader Std = cmd.ExecuteReader();
                
                Std.Close();
                LoginForm.sqlConnection1.Close();
                MessageBox.Show("Course is Deleted");
                txtCrsName.Text = String.Empty;

            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            //getcourse();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                LoginForm.sqlConnection1.Open();
                //updateCourseById must required
                SqlCommand cmd = new SqlCommand("updateCourseByID", LoginForm.sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(BoxCrsId.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Content", SqlDbType.NVarChar).Value = txtCrsName.Text.ToString().Trim();
               // cmd.Parameters.AddWithValue("@insId", SqlDbType.Int).Value = insId;
                int x = cmd.ExecuteNonQuery();
                if (x == -1)
                {
                    MessageBox.Show(" course is  not existed ");
                }
                else
                {
                    MessageBox.Show("You Course is update ");
                }

                LoginForm.sqlConnection1.Close();
                txtCrsName.Text = String.Empty;

            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            getcourse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTopic mTopic = new ManageTopic();
            this.Hide();
            mTopic.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
