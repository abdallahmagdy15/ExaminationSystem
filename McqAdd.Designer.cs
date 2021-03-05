
namespace Examination
{
    partial class McqAdd
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtQnContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmBoxCrId = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQnGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQnAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCh2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCh1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCh4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCh3 = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(165, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Question Content";
            // 
            // txtQnContent
            // 
            this.txtQnContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQnContent.Location = new System.Drawing.Point(330, 121);
            this.txtQnContent.Name = "txtQnContent";
            this.txtQnContent.Size = new System.Drawing.Size(309, 23);
            this.txtQnContent.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(178, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Course ID";
            // 
            // cmBoxCrId
            // 
            this.cmBoxCrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmBoxCrId.FormattingEnabled = true;
            this.cmBoxCrId.Location = new System.Drawing.Point(330, 55);
            this.cmBoxCrId.Name = "cmBoxCrId";
            this.cmBoxCrId.Size = new System.Drawing.Size(309, 24);
            this.cmBoxCrId.TabIndex = 40;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(478, 462);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 41);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 524);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add New Question";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(257, 462);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 41);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(176, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Question Grade";
            // 
            // txtQnGrade
            // 
            this.txtQnGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQnGrade.Location = new System.Drawing.Point(330, 187);
            this.txtQnGrade.Name = "txtQnGrade";
            this.txtQnGrade.Size = new System.Drawing.Size(309, 23);
            this.txtQnGrade.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(176, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Question Answer";
            // 
            // txtQnAnswer
            // 
            this.txtQnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQnAnswer.Location = new System.Drawing.Point(330, 248);
            this.txtQnAnswer.Name = "txtQnAnswer";
            this.txtQnAnswer.Size = new System.Drawing.Size(309, 23);
            this.txtQnAnswer.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(442, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Choice";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCh2
            // 
            this.txtCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCh2.Location = new System.Drawing.Point(531, 317);
            this.txtCh2.Name = "txtCh2";
            this.txtCh2.Size = new System.Drawing.Size(141, 23);
            this.txtCh2.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(172, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Choice";
            // 
            // txtCh1
            // 
            this.txtCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCh1.Location = new System.Drawing.Point(246, 317);
            this.txtCh1.Name = "txtCh1";
            this.txtCh1.Size = new System.Drawing.Size(141, 23);
            this.txtCh1.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(442, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Choice";
            // 
            // txtCh4
            // 
            this.txtCh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCh4.Location = new System.Drawing.Point(531, 393);
            this.txtCh4.Name = "txtCh4";
            this.txtCh4.Size = new System.Drawing.Size(141, 23);
            this.txtCh4.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(172, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Choice";
            // 
            // txtCh3
            // 
            this.txtCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCh3.Location = new System.Drawing.Point(246, 393);
            this.txtCh3.Name = "txtCh3";
            this.txtCh3.Size = new System.Drawing.Size(141, 23);
            this.txtCh3.TabIndex = 56;
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
            // McqAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCh4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCh3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCh2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCh1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQnAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQnGrade);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQnContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmBoxCrId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Name = "McqAdd";
            this.Text = "McqAdd";
            this.Load += new System.EventHandler(this.McqAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQnContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmBoxCrId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQnGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQnAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCh2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCh1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCh4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCh3;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}