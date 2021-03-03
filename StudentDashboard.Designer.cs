
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
            this.noExamsLabel = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.TabPage();
            this.dateLabel = new System.Windows.Forms.Label();
            this.crsLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.exDescLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.stNameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.TakeExam.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.TakeExam);
            this.tabControl1.Controls.Add(this.History);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // TakeExam
            // 
            this.TakeExam.Controls.Add(this.noExamsLabel);
            this.TakeExam.Location = new System.Drawing.Point(4, 25);
            this.TakeExam.Name = "TakeExam";
            this.TakeExam.Padding = new System.Windows.Forms.Padding(3);
            this.TakeExam.Size = new System.Drawing.Size(1041, 701);
            this.TakeExam.TabIndex = 0;
            this.TakeExam.Text = "Take Exam";
            this.TakeExam.UseVisualStyleBackColor = true;
            // 
            // noExamsLabel
            // 
            this.noExamsLabel.AutoSize = true;
            this.noExamsLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.noExamsLabel.Location = new System.Drawing.Point(372, 225);
            this.noExamsLabel.Name = "noExamsLabel";
            this.noExamsLabel.Size = new System.Drawing.Size(158, 46);
            this.noExamsLabel.TabIndex = 0;
            this.noExamsLabel.Text = "No Exams Found!\r\nTry Again Later";
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(4, 25);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(1041, 701);
            this.History.TabIndex = 1;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
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
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(12, 34);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.mainPanel.Size = new System.Drawing.Size(1045, 704);
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
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 754);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.TakeExam.ResumeLayout(false);
            this.TakeExam.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}