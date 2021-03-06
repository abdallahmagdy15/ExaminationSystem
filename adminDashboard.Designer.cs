
namespace Examination
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnGExam = new System.Windows.Forms.Button();
            this.instBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=mssql-21280-0.cloudclusters.net,21280;Initial Catalog=examination2019" +
    ";Persist Security Info=True;User ID=team;Password=Team2021";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStudent.Location = new System.Drawing.Point(18, 72);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(130, 41);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.instBtn);
            this.panel1.Controls.Add(this.questionsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.btnDepartments);
            this.panel1.Controls.Add(this.btnCourses);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 529);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // questionsBtn
            // 
            this.questionsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.questionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.questionsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.questionsBtn.Location = new System.Drawing.Point(18, 441);
            this.questionsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.questionsBtn.Name = "questionsBtn";
            this.questionsBtn.Size = new System.Drawing.Size(130, 41);
            this.questionsBtn.TabIndex = 7;
            this.questionsBtn.Text = "Questions";
            this.questionsBtn.UseVisualStyleBackColor = false;
            this.questionsBtn.Click += new System.EventHandler(this.instBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReports.Location = new System.Drawing.Point(18, 377);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(130, 41);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnExam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExam.Location = new System.Drawing.Point(18, 311);
            this.btnExam.Margin = new System.Windows.Forms.Padding(2);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(130, 41);
            this.btnExam.TabIndex = 4;
            this.btnExam.Text = "Exams";
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDepartments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDepartments.Location = new System.Drawing.Point(18, 127);
            this.btnDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(130, 41);
            this.btnDepartments.TabIndex = 3;
            this.btnDepartments.Text = "Department";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCourses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCourses.Location = new System.Drawing.Point(18, 245);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(130, 41);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnGExam
            // 
            this.btnGExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnGExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGExam.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGExam.Location = new System.Drawing.Point(298, 119);
            this.btnGExam.Name = "btnGExam";
            this.btnGExam.Size = new System.Drawing.Size(363, 56);
            this.btnGExam.TabIndex = 1;
            this.btnGExam.Text = "Generate Exam";
            this.btnGExam.UseVisualStyleBackColor = false;
            this.btnGExam.Click += new System.EventHandler(this.btnGExam_Click);
            // 
            // instBtn
            // 
            this.instBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.instBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.instBtn.Location = new System.Drawing.Point(18, 185);
            this.instBtn.Margin = new System.Windows.Forms.Padding(2);
            this.instBtn.Name = "instBtn";
            this.instBtn.Size = new System.Drawing.Size(130, 41);
            this.instBtn.TabIndex = 8;
            this.instBtn.Text = "Instructor";
            this.instBtn.UseVisualStyleBackColor = false;
            this.instBtn.Click += new System.EventHandler(this.instBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 529);
            this.Controls.Add(this.btnGExam);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.Text = "adminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnGExam;
        private System.Windows.Forms.Button questionsBtn;
        #endregion

        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button instBtn;
    }
}