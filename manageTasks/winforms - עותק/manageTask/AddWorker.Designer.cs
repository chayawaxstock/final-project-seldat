namespace manageTask
{
    partial class AddWorker
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_numHourWork = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.num_numHours = new System.Windows.Forms.NumericUpDown();
            this.cmbx_department = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmbx_teamLeader = new System.Windows.Forms.ComboBox();
            this.lbl_team_leader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(124, 72);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(124, 120);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(124, 175);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_numHourWork
            // 
            this.lbl_numHourWork.AutoSize = true;
            this.lbl_numHourWork.Location = new System.Drawing.Point(124, 221);
            this.lbl_numHourWork.Name = "lbl_numHourWork";
            this.lbl_numHourWork.Size = new System.Drawing.Size(58, 13);
            this.lbl_numHourWork.TabIndex = 3;
            this.lbl_numHourWork.Text = "Num hours";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(124, 280);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(62, 13);
            this.lbl_department.TabIndex = 4;
            this.lbl_department.Text = "Department";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(206, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(206, 175);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(206, 117);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 9;
            // 
            // num_numHours
            // 
            this.num_numHours.Location = new System.Drawing.Point(206, 221);
            this.num_numHours.Name = "num_numHours";
            this.num_numHours.Size = new System.Drawing.Size(100, 20);
            this.num_numHours.TabIndex = 10;
            this.num_numHours.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cmbx_department
            // 
            this.cmbx_department.FormattingEnabled = true;
            this.cmbx_department.Location = new System.Drawing.Point(206, 272);
            this.cmbx_department.Name = "cmbx_department";
            this.cmbx_department.Size = new System.Drawing.Size(100, 21);
            this.cmbx_department.TabIndex = 11;
            this.cmbx_department.SelectedIndexChanged += new System.EventHandler(this.cmbx_department_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(165, 381);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmbx_teamLeader
            // 
            this.cmbx_teamLeader.FormattingEnabled = true;
            this.cmbx_teamLeader.Location = new System.Drawing.Point(206, 326);
            this.cmbx_teamLeader.Name = "cmbx_teamLeader";
            this.cmbx_teamLeader.Size = new System.Drawing.Size(100, 21);
            this.cmbx_teamLeader.TabIndex = 13;
            this.cmbx_teamLeader.Visible = false;
            // 
            // lbl_team_leader
            // 
            this.lbl_team_leader.AutoSize = true;
            this.lbl_team_leader.Location = new System.Drawing.Point(124, 329);
            this.lbl_team_leader.Name = "lbl_team_leader";
            this.lbl_team_leader.Size = new System.Drawing.Size(63, 13);
            this.lbl_team_leader.TabIndex = 14;
            this.lbl_team_leader.Text = "Teamleader";
            this.lbl_team_leader.Visible = false;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 496);
            this.Controls.Add(this.lbl_team_leader);
            this.Controls.Add(this.cmbx_teamLeader);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbx_department);
            this.Controls.Add(this.num_numHours);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_numHourWork);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Name = "AddWorker";
            this.Text = "Add a new worker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_numHourWork;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.NumericUpDown num_numHours;
        private System.Windows.Forms.ComboBox cmbx_department;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmbx_teamLeader;
        private System.Windows.Forms.Label lbl_team_leader;
    }
}