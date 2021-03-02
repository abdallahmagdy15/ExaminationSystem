using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //byte[] passwordHashed = new byte[] { };

            //var md5 = new MD5CryptoServiceProvider();
            //var data = Encoding.ASCII.GetBytes("12345678");
            //passwordHashed = md5.ComputeHash(data);
            //unameTxtBox.Text= Encoding.ASCII.GetString(passwordHashed);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //validation
            if (!Regex.Match(unameTxtBox.Text, "^[a-zA-Z]*$").Success)
            {
                MessageBox.Show("Username is not valid");
                unameTxtBox.Focus();
                return;
            }

            //if (!Regex.Match(passTxtBox.Text, @"^(.{0,7}|[^0-9]*|[^A-Z])$").Success)
            //{
            //    MessageBox.Show("Password is not valid");
            //    unameTxtBox.Focus();
            //    return;
            //}

            //encrypting the password before passing it to login procedure
            byte[] passwordHashed = new byte[] { };
            try
            {
                var md5 = new MD5CryptoServiceProvider();
                var data = Encoding.ASCII.GetBytes(passTxtBox.Text);
                passwordHashed = md5.ComputeHash(data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }

            sqlCommand1.CommandText = "Login @uname, @pass";
            sqlCommand1.Parameters.AddWithValue("@uname", unameTxtBox.Text);
            sqlCommand1.Parameters.AddWithValue("@pass",
                Encoding.ASCII.GetString(passwordHashed));
            SqlDataReader dr = null;
            try
            {
                sqlConnection1.Open();
                dr = sqlCommand1.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    //if true then he is a student
                    if ((bool)dr[0])
                    {
                        CurrentStudent = new Student(dr.GetInt32(1), dr.GetString(2) + ' ' + dr.GetString(3), dr.GetDateTime(4), dr.GetString(6));
                        dr.Close();
                        sqlConnection1.Close();
                        var dashboard = new StudentDashboard();
                        // closes hidden prev window if dashboard is closed
                        dashboard.Closed += (s, args) => this.Close();
                        dashboard.Show();
                    }

                    else
                    {
                        dr.Close();
                        sqlConnection1.Close();
                        var dashboard = new AdminDashboard();
                        // closes hidden prev window if dashboard is closed
                        dashboard.Closed += (s, args) => this.Close();
                        dashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
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
                sqlConnection1.Close();
                sqlCommand1.Parameters.Clear();
            }
        }
    }
}
