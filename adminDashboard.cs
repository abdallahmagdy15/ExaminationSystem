using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ManageStudent mStudent = new ManageStudent();
            //this.Visible = false;
            // mStudent.ShowDialog();
            this.Hide();
            mStudent.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ManageCourse mCourse = new ManageCourse();
            //this.Visible = false;
           // mCourse.ShowDialog();
            this.Hide();
            mCourse.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageInstructor mInstructor = new ManageInstructor();
           // this.Visible = false;
            //.ShowDialog();
            this.Hide();
            mInstructor.ShowDialog();
            this.Close();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            ManageExam Ex = new ManageExam();
            this.Visible = false;
            Ex.ShowDialog();
        }
        private void btnGExam_Click(object sender, EventArgs e)
        {
            ExamGeneration exGenerate = new ExamGeneration();
            this.Visible = false;
            exGenerate.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageQuestion Qn = new ManageQuestion();
            this.Visible = false;
            Qn.ShowDialog();
        }
        private void btnDepartments_Click(object sender, EventArgs e)
        {
            MangeDepartment form = new MangeDepartment();
            this.Visible = false;
            form.ShowDialog();
        }
    }
}
