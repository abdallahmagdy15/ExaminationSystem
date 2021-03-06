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
    public partial class MangeDepartment : Form
    {
        public MangeDepartment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string DName = txtFName.Text;
            string MngrId = txtSMangerId.Text;
            string HireDate = txtHireDate.Text;
            //string Did = BoxDepId.Text;


            if (DName == "" || DName == null && MngrId == "" || MngrId == null && HireDate == "" || HireDate == null )
            {
                MessageBox.Show("Please enter valid Data");
                return;
            }
           

                string insert = "insertDepartment @DName, @MngrId,@HireDate";

            try
            {
                sqlCommand1.Parameters.AddWithValue("@DName", DName);
                sqlCommand1.Parameters.AddWithValue("@HireDate", HireDate);
                sqlCommand1.Parameters.AddWithValue("@MngrId", MngrId);
                sqlCommand1.CommandText = insert;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " Department Added");
                DName =  HireDate = MngrId = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string DName = txtFName.Text;
            string MngrId = txtSMangerId.Text;
            string HireDate = txtHireDate.Text;
            string Did = BoxDepId.Text;

            if (Did == "" || Did == null &&  DName == "" || DName == null && MngrId == "" || MngrId == null && HireDate == "" || HireDate == null)
            {
                MessageBox.Show("Please enter valid Data");
                return;
            }

            string Update = "updateDepartmentByid @Did, @DName, @MngrId,@HireDate";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@Did", Did);
                sqlCommand1.Parameters.AddWithValue("@DName", DName);
                sqlCommand1.Parameters.AddWithValue("@HireDate", HireDate);
                sqlCommand1.Parameters.AddWithValue("@MngrId", MngrId);
                sqlCommand1.CommandText = Update;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show(AffectedRows + " Department updated");
                Did = DName = HireDate = MngrId = string.Empty;

            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int flag = 0;
            string Did = BoxDepId.Text;
            if (Did == "" || Did == null)
            {
                MessageBox.Show("Please enter valid ID");
                return;
            }
            int id = int.Parse(BoxDepId.Text);


            try
            {

                string FindDept = "getDeptById @id";
                sqlCommand1.Parameters.AddWithValue("@id", id);
                sqlCommand1.CommandText = FindDept;
                SqlDataReader dReader;
                sqlConnection1.Open();
                dReader = sqlCommand1.ExecuteReader();

                while (dReader.Read())
                {
                    flag = 1;
                    BoxDepId.Text = dReader["Dept_Id"].ToString();
                    txtDetName.Text = dReader["Dept_Name"].ToString();
                    txtSMangerId.Text = dReader["Dept_Mgr"].ToString();
                    txtHireDate.Text = dReader["Mgr_HireDate"].ToString();
                }
                if (flag == 0) { MessageBox.Show("this Id " + id + " Not exist"); }
                dReader.Close();
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("this Department " + id + " Not exist");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Did = BoxDepId.Text;
            if(Did == "" || Did == null)
            {
                MessageBox.Show("please enter valid id");
                return;
            }

            string DeleteDept = "DeleteDeptById @Did";
            try
            {
                sqlCommand1.Parameters.AddWithValue("@Did", Did);
                
                sqlCommand1.CommandText = DeleteDept;

                sqlConnection1.Open();
                int AffectedRows = sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                
                MessageBox.Show(AffectedRows + " Department Deleted");
                Did  = string.Empty;

            }
            catch
            {
                MessageBox.Show("This id doesnot exist please enter valid id");
                return;
                
            }
        }
    }
}
