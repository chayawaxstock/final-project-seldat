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
            this.lbl_name = new Telerik.WinControls.UI.RadLabel();
            this.lbl_password = new Telerik.WinControls.UI.RadLabel();
            this.lbl_email = new Telerik.WinControls.UI.RadLabel();
            this.lbl_numHourWork = new Telerik.WinControls.UI.RadLabel();
            this.lbl_department = new Telerik.WinControls.UI.RadLabel();
            this.txt_name = new Telerik.WinControls.UI.RadTextBox();
            this.txt_email = new Telerik.WinControls.UI.RadTextBox();
            this.txt_password = new Telerik.WinControls.UI.RadTextBox();
            this.btn_add = new Telerik.WinControls.UI.RadButton();
            this.lbl_team_leader = new Telerik.WinControls.UI.RadLabel();
            this.cmbx_department = new System.Windows.Forms.ComboBox();
            this.cmbx_teamLeader = new System.Windows.Forms.ComboBox();
            this.num_numHours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_numHourWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_team_leader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(124, 72);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(36, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_password
            // 
            this.lbl_password.Location = new System.Drawing.Point(124, 120);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 18);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.Location = new System.Drawing.Point(124, 175);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(33, 18);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_numHourWork
            // 
            this.lbl_numHourWork.Location = new System.Drawing.Point(124, 221);
            this.lbl_numHourWork.Name = "lbl_numHourWork";
            this.lbl_numHourWork.Size = new System.Drawing.Size(62, 18);
            this.lbl_numHourWork.TabIndex = 3;
            this.lbl_numHourWork.Text = "Num hours";
            // 
            // lbl_department
            // 
            this.lbl_department.Location = new System.Drawing.Point(124, 280);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(66, 18);
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(165, 381);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            // 
            // lbl_team_leader
            // 
            this.lbl_team_leader.Location = new System.Drawing.Point(124, 329);
            this.lbl_team_leader.Name = "lbl_team_leader";
            this.lbl_team_leader.Size = new System.Drawing.Size(65, 18);
            this.lbl_team_leader.TabIndex = 14;
            this.lbl_team_leader.Text = "Teamleader";
            this.lbl_team_leader.Visible = false;
            // 
            // cmbx_department
            // 
            this.cmbx_department.FormattingEnabled = true;
            this.cmbx_department.Location = new System.Drawing.Point(206, 280);
            this.cmbx_department.Name = "cmbx_department";
            this.cmbx_department.Size = new System.Drawing.Size(100, 21);
            this.cmbx_department.TabIndex = 16;
            // 
            // cmbx_teamLeader
            // 
            this.cmbx_teamLeader.FormattingEnabled = true;
            this.cmbx_teamLeader.Location = new System.Drawing.Point(206, 329);
            this.cmbx_teamLeader.Name = "cmbx_teamLeader";
            this.cmbx_teamLeader.Size = new System.Drawing.Size(100, 21);
            this.cmbx_teamLeader.TabIndex = 17;
            // 
            // num_numHours
            // 
            this.num_numHours.Location = new System.Drawing.Point(206, 221);
            this.num_numHours.Name = "num_numHours";
            this.num_numHours.Size = new System.Drawing.Size(100, 20);
            this.num_numHours.TabIndex = 18;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 496);
            this.Controls.Add(this.num_numHours);
            this.Controls.Add(this.cmbx_teamLeader);
            this.Controls.Add(this.cmbx_department);
            this.Controls.Add(this.lbl_team_leader);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_numHourWork);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Name = "AddWorker";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Add a new worker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_numHourWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_team_leader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbl_name;
        private Telerik.WinControls.UI.RadLabel lbl_password;
        private Telerik.WinControls.UI.RadLabel lbl_email;
        private Telerik.WinControls.UI.RadLabel lbl_numHourWork;
        private Telerik.WinControls.UI.RadLabel lbl_department;
        private Telerik.WinControls.UI.RadTextBox txt_name;
        private Telerik.WinControls.UI.RadTextBox txt_email;
        private Telerik.WinControls.UI.RadTextBox txt_password;
        private Telerik.WinControls.UI.RadButton btn_add;
        private Telerik.WinControls.UI.RadLabel lbl_team_leader;
        private System.Windows.Forms.ComboBox cmbx_department;
        private System.Windows.Forms.ComboBox cmbx_teamLeader;
        private System.Windows.Forms.NumericUpDown num_numHours;
    }
}