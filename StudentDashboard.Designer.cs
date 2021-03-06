
namespace Examination
{
    partial class StudentDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TakeExam = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.stNameLabel = new System.Windows.Forms.Label();
            this.crsLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.exDescLabel = new System.Windows.Forms.Label();
            this.noExamsLabel = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.TabPage();
            this.historyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.accountCard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StName = new System.Windows.Forms.Label();
            this.StDept = new System.Windows.Forms.Label();
            this.StBD = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TakeExam.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.History.SuspendLayout();
            this.accountCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.TakeExam);
            this.tabControl1.Controls.Add(this.History);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 725);
            this.tabControl1.TabIndex = 0;
            // 
            // TakeExam
            // 
            this.TakeExam.Controls.Add(this.mainPanel);
            this.TakeExam.Controls.Add(this.noExamsLabel);
            this.TakeExam.Location = new System.Drawing.Point(4, 25);
            this.TakeExam.Name = "TakeExam";
            this.TakeExam.Padding = new System.Windows.Forms.Padding(3);
            this.TakeExam.Size = new System.Drawing.Size(1041, 696);
            this.TakeExam.TabIndex = 0;
            this.TakeExam.Text = "Take Exam";
            this.TakeExam.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(6, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.mainPanel.Size = new System.Drawing.Size(1045, 699);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Visible = false;
            this.mainPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.stNameLabel);
            this.panel1.Controls.Add(this.crsLabel);
            this.panel1.Controls.Add(this.deptLabel);
            this.panel1.Controls.Add(this.durationLabel);
            this.panel1.Controls.Add(this.exDescLabel);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 100);
            this.panel1.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateLabel.Location = new System.Drawing.Point(674, 47);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date : ";
            // 
            // stNameLabel
            // 
            this.stNameLabel.AutoSize = true;
            this.stNameLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.stNameLabel.Location = new System.Drawing.Point(21, 30);
            this.stNameLabel.Name = "stNameLabel";
            this.stNameLabel.Size = new System.Drawing.Size(109, 17);
            this.stNameLabel.TabIndex = 0;
            this.stNameLabel.Text = "Student Name : ";
            // 
            // crsLabel
            // 
            this.crsLabel.AutoSize = true;
            this.crsLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.crsLabel.Location = new System.Drawing.Point(674, 30);
            this.crsLabel.Name = "crsLabel";
            this.crsLabel.Size = new System.Drawing.Size(64, 17);
            this.crsLabel.TabIndex = 4;
            this.crsLabel.Text = "Course : ";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deptLabel.Location = new System.Drawing.Point(21, 47);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(95, 17);
            this.deptLabel.TabIndex = 1;
            this.deptLabel.Text = "Department : ";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.durationLabel.Location = new System.Drawing.Point(344, 47);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(113, 17);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Exam Duration : ";
            // 
            // exDescLabel
            // 
            this.exDescLabel.AutoSize = true;
            this.exDescLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.exDescLabel.Location = new System.Drawing.Point(344, 30);
            this.exDescLabel.Name = "exDescLabel";
            this.exDescLabel.Size = new System.Drawing.Size(128, 17);
            this.exDescLabel.TabIndex = 2;
            this.exDescLabel.Text = "Exam Description : ";
            // 
            // noExamsLabel
            // 
            this.noExamsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noExamsLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.noExamsLabel.Location = new System.Drawing.Point(429, 314);
            this.noExamsLabel.Name = "noExamsLabel";
            this.noExamsLabel.Size = new System.Drawing.Size(158, 46);
            this.noExamsLabel.TabIndex = 0;
            this.noExamsLabel.Text = "No Exams Found!\r\nTry Again Later";
            // 
            // History
            // 
            this.History.Controls.Add(this.historyPanel);
            this.History.Location = new System.Drawing.Point(4, 25);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(1041, 696);
            this.History.TabIndex = 1;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // historyPanel
            // 
            this.historyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historyPanel.AutoScroll = true;
            this.historyPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.historyPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.historyPanel.Location = new System.Drawing.Point(3, 3);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Padding = new System.Windows.Forms.Padding(8);
            this.historyPanel.Size = new System.Drawing.Size(1035, 690);
            this.historyPanel.TabIndex = 2;
            this.historyPanel.WrapContents = false;
            // 
            // AccountBtn
            // 
            this.AccountBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.AccountBtn.BackgroundImage = global::Examination.Properties.Resources.png_clipart_teacher_education_student_course_school_avatar_child_face;
            this.AccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AccountBtn.Location = new System.Drawing.Point(1007, 12);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(47, 45);
            this.AccountBtn.TabIndex = 1;
            this.AccountBtn.UseVisualStyleBackColor = false;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // accountCard
            // 
            this.accountCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountCard.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.accountCard.Controls.Add(this.StBD);
            this.accountCard.Controls.Add(this.StDept);
            this.accountCard.Controls.Add(this.StName);
            this.accountCard.Controls.Add(this.button1);
            this.accountCard.Controls.Add(this.label3);
            this.accountCard.Controls.Add(this.label2);
            this.accountCard.Controls.Add(this.label1);
            this.accountCard.Location = new System.Drawing.Point(576, 12);
            this.accountCard.Name = "accountCard";
            this.accountCard.Size = new System.Drawing.Size(425, 242);
            this.accountCard.TabIndex = 2;
            this.accountCard.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button1.Location = new System.Drawing.Point(24, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StName
            // 
            this.StName.AutoSize = true;
            this.StName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StName.Location = new System.Drawing.Point(148, 36);
            this.StName.Name = "StName";
            this.StName.Size = new System.Drawing.Size(0, 19);
            this.StName.TabIndex = 5;
            // 
            // StDept
            // 
            this.StDept.AutoSize = true;
            this.StDept.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StDept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StDept.Location = new System.Drawing.Point(148, 69);
            this.StDept.Name = "StDept";
            this.StDept.Size = new System.Drawing.Size(0, 19);
            this.StDept.TabIndex = 6;
            // 
            // StBD
            // 
            this.StBD.AutoSize = true;
            this.StBD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StBD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StBD.Location = new System.Drawing.Point(148, 106);
            this.StBD.Name = "StBD";
            this.StBD.Size = new System.Drawing.Size(0, 19);
            this.StBD.TabIndex = 7;
            this.StBD.Visible = false;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1073, 754);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.accountCard);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.TakeExam.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.History.ResumeLayout(false);
            this.accountCard.ResumeLayout(false);
            this.accountCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TakeExam;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.Label noExamsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label crsLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label exDescLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label stNameLabel;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel historyPanel;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Panel accountCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StBD;
        private System.Windows.Forms.Label StDept;
        private System.Windows.Forms.Label StName;
    }
}