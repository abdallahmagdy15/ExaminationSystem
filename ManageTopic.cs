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
    public partial class ManageTopic : Form
    {
        Dictionary<int, string> CrsDic = new Dictionary<int, string>();
        int CrsId;
        public ManageTopic()
        {
            InitializeComponent();
        }

        private void ManageTopic_Load(object sender, EventArgs e)
        {
            try
            {
                LoginForm.sqlConnection1.Open();
                // sqlConnection1.Open();
                SqlCommand crs = new SqlCommand("GET_ALL_TOPICS", LoginForm.sqlConnection1);
                crs.CommandType = CommandType.StoredProcedure;
                SqlDataReader Crs = crs.ExecuteReader();
                while (Crs.Read())
                {

                    BoxCrsId.Items.Add(Crs["Top_Id"].ToString());


                }
                Crs.Close();


            }
            catch
            {
                MessageBox.Show(" No topic To Show ");
                throw;
            }
            finally
            {
                LoginForm.sqlConnection1.Close();

            }

            gettopic();
            GetCourseTopic();

        }
        private void gettopic()
        {
            try
            {
                LoginForm.sqlConnection1.Open();
                SqlCommand std = new SqlCommand("GET_ALL_TOPICS", LoginForm.sqlConnection1);
                
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
        private void GetCourseTopic()
        {
            try
            {
                LoginForm.sqlConnection1.Open();
                SqlCommand std = new SqlCommand("GET_ALL_COURSES", LoginForm.sqlConnection1);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    CrsDic.Add(int.Parse(Std["Crs_Id"].ToString()), Std["Crs_Name"].ToString());
                    cmbInsName.Items.Add(Std["Crs_Name"]).ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            ManageCourse cr = new ManageCourse();

            // this.Visible = false;
            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        private void cmbInsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in CrsDic)
            {
                if (cmbInsName.SelectedItem.ToString() == item.Value)
                {
                    CrsId = item.Key;
                    break;
                }
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
                    SqlCommand cmd = new SqlCommand("addTopic", LoginForm.sqlConnection1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@topicName", SqlDbType.NVarChar).Value = txtCrsName.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@CrsId", SqlDbType.Int).Value = CrsId;
                    int x = cmd.ExecuteNonQuery();
                    if (x == -1)
                    {
                        MessageBox.Show(" Topic is  existed ");
                    }
                    else
                    {
                        MessageBox.Show("You Added New Topic ");
                    }

                    LoginForm.sqlConnection1.Close();
                    cmd.Parameters.Clear();
                    txtCrsName.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            // GetCourseIns();
            gettopic();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm.sqlConnection1.Open();
                SqlCommand std = new SqlCommand("Get_Topics_by_CrsID", LoginForm.sqlConnection1);

                std.CommandType = CommandType.StoredProcedure;
                std.Parameters.AddWithValue("@Cid", SqlDbType.Int).Value = CrsId;
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                LoginForm.sqlConnection1.Open();
                //updateCourseById must required
                SqlCommand cmd = new SqlCommand("[updateTopic]", LoginForm.sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(BoxCrsId.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = txtCrsName.Text.ToString().Trim();
                // cmd.Parameters.AddWithValue("@insId", SqlDbType.Int).Value = insId;
                int x = cmd.ExecuteNonQuery();
                if (x == -1)
                {
                    MessageBox.Show(" Topic is  not existed ");
                }
                else
                {
                    MessageBox.Show("You topic is update ");
                }

                LoginForm.sqlConnection1.Close();
                cmd.Parameters.Clear();
               txtCrsName.Text = String.Empty;

            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            gettopic();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                LoginForm.sqlConnection1.Open();
                //DeleteCourseById must required
                SqlCommand cmd = new SqlCommand("deleteTopic", LoginForm.sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(BoxCrsId.SelectedItem.ToString());
                SqlDataReader Std = cmd.ExecuteReader();

                Std.Close();
                LoginForm.sqlConnection1.Close();
                cmd.Parameters.Clear();
                MessageBox.Show("Topic is Deleted");
                txtCrsName.Text = String.Empty;

            }
            catch
            {
                MessageBox.Show(" Please Enter Valid Data ");
                throw;
            }
            gettopic();
        }
    }
}
