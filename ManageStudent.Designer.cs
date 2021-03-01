
namespace Examination
{
    partial class ManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
            this.label6 = new System.Windows.Forms.Label();
            this.BoxDepId = new System.Windows.Forms.ComboBox();
            this.txtStId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStBd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(262, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Dept ID";
            // 
            // BoxDepId
            // 
            this.BoxDepId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BoxDepId.FormattingEnabled = true;
            this.BoxDepId.Location = new System.Drawing.Point(346, 41);
            this.BoxDepId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxDepId.Name = "BoxDepId";
            this.BoxDepId.Size = new System.Drawing.Size(233, 24);
            this.BoxDepId.TabIndex = 27;
            // 
            // txtStId
            // 
            this.txtStId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStId.Location = new System.Drawing.Point(346, 202);
            this.txtStId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStId.Name = "txtStId";
            this.txtStId.Size = new System.Drawing.Size(233, 23);
            this.txtStId.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(277, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(346, 309);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 41);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(255, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "First Name";
            // 
            // txtStFName
            // 
            this.txtStFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStFName.Location = new System.Drawing.Point(346, 153);
            this.txtStFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStFName.Name = "txtStFName";
            this.txtStFName.Size = new System.Drawing.Size(233, 23);
            this.txtStFName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(255, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Birth Date";
            // 
            // txtStBd
            // 
            this.txtStBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStBd.Location = new System.Drawing.Point(346, 247);
            this.txtStBd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStBd.Name = "txtStBd";
            this.txtStBd.Size = new System.Drawing.Size(233, 23);
            this.txtStBd.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(255, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name";
            // 
            // txtStName
            // 
            this.txtStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStName.Location = new System.Drawing.Point(346, 104);
            this.txtStName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(233, 23);
            this.txtStName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Dashboard";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(9, 309);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(9, 188);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 41);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 387);
            this.panel1.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(9, 247);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(9, 129);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=mssql-21280-0.cloudclusters.net,21280;Initial Catalog=examination2019" +
    ";Persist Security Info=True;User ID=team;Password=Team2021";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BoxDepId);
            this.Controls.Add(this.txtStId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStBd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStudent";
            this.Text = "mangeStudent";
            this.Load += new System.EventHandler(this.mangeStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BoxDepId;
        private System.Windows.Forms.TextBox txtStId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStBd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}