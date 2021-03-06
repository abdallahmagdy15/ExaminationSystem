
namespace Examination
{
    partial class ManageExam
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExQnList = new System.Windows.Forms.ListBox();
            this.txtQnContent = new System.Windows.Forms.TextBox();
            this.txtQnId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExDate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExDuration = new System.Windows.Forms.TextBox();
            this.txtExDesc = new System.Windows.Forms.TextBox();
            this.cmBoxExId = new System.Windows.Forms.ComboBox();
            this.cmBoxCrsId = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.txtQnType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddQn = new System.Windows.Forms.Button();
            this.btnDeleteQn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.btnDeleteQn);
            this.panel4.Controls.Add(this.btnAddQn);
            this.panel4.Controls.Add(this.txtQnType);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.ExQnList);
            this.panel4.Controls.Add(this.txtQnContent);
            this.panel4.Controls.Add(this.txtQnId);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(721, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 381);
            this.panel4.TabIndex = 66;
            // 
            // ExQnList
            // 
            this.ExQnList.BackColor = System.Drawing.SystemColors.Control;
            this.ExQnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExQnList.FormattingEnabled = true;
            this.ExQnList.ItemHeight = 16;
            this.ExQnList.Location = new System.Drawing.Point(16, 10);
            this.ExQnList.Name = "ExQnList";
            this.ExQnList.Size = new System.Drawing.Size(240, 292);
            this.ExQnList.TabIndex = 5;
            this.ExQnList.SelectedIndexChanged += new System.EventHandler(this.ExQnList_SelectedIndexChanged);
            // 
            // txtQnContent
            // 
            this.txtQnContent.Location = new System.Drawing.Point(313, 232);
            this.txtQnContent.Name = "txtQnContent";
            this.txtQnContent.Size = new System.Drawing.Size(157, 20);
            this.txtQnContent.TabIndex = 4;
            // 
            // txtQnId
            // 
            this.txtQnId.Location = new System.Drawing.Point(329, 47);
            this.txtQnId.Name = "txtQnId";
            this.txtQnId.Size = new System.Drawing.Size(101, 20);
            this.txtQnId.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Question Content";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Question ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(827, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 46);
            this.panel3.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exam Question";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(340, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 46);
            this.panel2.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(40, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exam Details";
            // 
            // txtExDate
            // 
            this.txtExDate.Location = new System.Drawing.Point(457, 310);
            this.txtExDate.Name = "txtExDate";
            this.txtExDate.Size = new System.Drawing.Size(169, 20);
            this.txtExDate.TabIndex = 63;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(584, 472);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 41);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(294, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Exam Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(281, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Exam Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(281, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Exam Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(300, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Exam ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(300, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Course ID";
            // 
            // txtExDuration
            // 
            this.txtExDuration.Location = new System.Drawing.Point(457, 249);
            this.txtExDuration.Name = "txtExDuration";
            this.txtExDuration.Size = new System.Drawing.Size(169, 20);
            this.txtExDuration.TabIndex = 56;
            // 
            // txtExDesc
            // 
            this.txtExDesc.Location = new System.Drawing.Point(457, 193);
            this.txtExDesc.Name = "txtExDesc";
            this.txtExDesc.Size = new System.Drawing.Size(169, 20);
            this.txtExDesc.TabIndex = 55;
            // 
            // cmBoxExId
            // 
            this.cmBoxExId.FormattingEnabled = true;
            this.cmBoxExId.Location = new System.Drawing.Point(457, 138);
            this.cmBoxExId.Name = "cmBoxExId";
            this.cmBoxExId.Size = new System.Drawing.Size(169, 21);
            this.cmBoxExId.TabIndex = 54;
            this.cmBoxExId.SelectedIndexChanged += new System.EventHandler(this.cmBoxExId_SelectedIndexChanged);
            // 
            // cmBoxCrsId
            // 
            this.cmBoxCrsId.FormattingEnabled = true;
            this.cmBoxCrsId.Location = new System.Drawing.Point(457, 82);
            this.cmBoxCrsId.Name = "cmBoxCrsId";
            this.cmBoxCrsId.Size = new System.Drawing.Size(169, 21);
            this.cmBoxCrsId.TabIndex = 53;
            this.cmBoxCrsId.SelectedIndexChanged += new System.EventHandler(this.cmBoxCrsId_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 524);
            this.panel1.TabIndex = 52;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(11, 261);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(11, 145);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 41);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exam Dashboard";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=mssql-21280-0.cloudclusters.net,21280;Initial Catalog=examination2019" +
    ";User ID=team;Password=Team2021";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // txtQnType
            // 
            this.txtQnType.Location = new System.Drawing.Point(329, 139);
            this.txtQnType.Name = "txtQnType";
            this.txtQnType.Size = new System.Drawing.Size(101, 20);
            this.txtQnType.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Question Type";
            // 
            // btnAddQn
            // 
            this.btnAddQn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnAddQn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddQn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddQn.Location = new System.Drawing.Point(106, 320);
            this.btnAddQn.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQn.Name = "btnAddQn";
            this.btnAddQn.Size = new System.Drawing.Size(130, 41);
            this.btnAddQn.TabIndex = 63;
            this.btnAddQn.Text = "Add";
            this.btnAddQn.UseVisualStyleBackColor = false;
            this.btnAddQn.Click += new System.EventHandler(this.btnAddQn_Click);
            // 
            // btnDeleteQn
            // 
            this.btnDeleteQn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnDeleteQn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteQn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteQn.Location = new System.Drawing.Point(300, 320);
            this.btnDeleteQn.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteQn.Name = "btnDeleteQn";
            this.btnDeleteQn.Size = new System.Drawing.Size(130, 41);
            this.btnDeleteQn.TabIndex = 64;
            this.btnDeleteQn.Text = "Delete";
            this.btnDeleteQn.UseVisualStyleBackColor = false;
            this.btnDeleteQn.Click += new System.EventHandler(this.btnDeleteQn_Click);
            // 
            // ManageExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtExDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExDuration);
            this.Controls.Add(this.txtExDesc);
            this.Controls.Add(this.cmBoxExId);
            this.Controls.Add(this.cmBoxCrsId);
            this.Controls.Add(this.panel1);
            this.Name = "ManageExam";
            this.Text = "ManageExam";
            this.Load += new System.EventHandler(this.ManageExam_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox ExQnList;
        private System.Windows.Forms.TextBox txtQnContent;
        private System.Windows.Forms.TextBox txtQnId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExDuration;
        private System.Windows.Forms.TextBox txtExDesc;
        private System.Windows.Forms.ComboBox cmBoxExId;
        private System.Windows.Forms.ComboBox cmBoxCrsId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox txtQnType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteQn;
        private System.Windows.Forms.Button btnAddQn;
    }
}