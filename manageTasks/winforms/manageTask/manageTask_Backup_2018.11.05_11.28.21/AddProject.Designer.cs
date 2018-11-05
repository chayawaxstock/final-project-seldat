namespace manageTask
{
    partial class AddProject
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_num_hors = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_qa = new System.Windows.Forms.NumericUpDown();
            this.txt_development = new System.Windows.Forms.NumericUpDown();
            this.txt_ui = new System.Windows.Forms.NumericUpDown();
            this.txt_ux = new System.Windows.Forms.NumericUpDown();
            this.lbl_ux = new System.Windows.Forms.Label();
            this.lbl_qa = new System.Windows.Forms.Label();
            this.lbl_development = new System.Windows.Forms.Label();
            this.lbl_ui = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.btn_add_project = new System.Windows.Forms.Button();
            this.lbl_teamleaders = new System.Windows.Forms.Label();
            this.cmbx_team_leader = new System.Windows.Forms.ComboBox();
            this.lbl_date_end = new System.Windows.Forms.Label();
            this.lbl_date_begin = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_num_hours = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_hors)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_development)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ux)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_num_hors);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dateTimeEnd);
            this.groupBox3.Controls.Add(this.dateTimeBegin);
            this.groupBox3.Controls.Add(this.btn_add_project);
            this.groupBox3.Controls.Add(this.lbl_teamleaders);
            this.groupBox3.Controls.Add(this.cmbx_team_leader);
            this.groupBox3.Controls.Add(this.lbl_date_end);
            this.groupBox3.Controls.Add(this.lbl_date_begin);
            this.groupBox3.Controls.Add(this.lbl_customer);
            this.groupBox3.Controls.Add(this.lbl_num_hours);
            this.groupBox3.Controls.Add(this.txt_customer);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.lbl_name);
            this.groupBox3.Location = new System.Drawing.Point(115, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 569);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add a new project";
            // 
            // txt_num_hors
            // 
            this.txt_num_hors.Location = new System.Drawing.Point(119, 87);
            this.txt_num_hors.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_num_hors.Name = "txt_num_hors";
            this.txt_num_hors.Size = new System.Drawing.Size(134, 20);
            this.txt_num_hors.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_qa);
            this.groupBox4.Controls.Add(this.txt_development);
            this.groupBox4.Controls.Add(this.txt_ui);
            this.groupBox4.Controls.Add(this.txt_ux);
            this.groupBox4.Controls.Add(this.lbl_ux);
            this.groupBox4.Controls.Add(this.lbl_qa);
            this.groupBox4.Controls.Add(this.lbl_development);
            this.groupBox4.Controls.Add(this.lbl_ui);
            this.groupBox4.Location = new System.Drawing.Point(45, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 205);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "hours for each department";
            // 
            // txt_qa
            // 
            this.txt_qa.Location = new System.Drawing.Point(105, 155);
            this.txt_qa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_qa.Name = "txt_qa";
            this.txt_qa.Size = new System.Drawing.Size(65, 20);
            this.txt_qa.TabIndex = 10;
            // 
            // txt_development
            // 
            this.txt_development.Location = new System.Drawing.Point(105, 110);
            this.txt_development.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_development.Name = "txt_development";
            this.txt_development.Size = new System.Drawing.Size(65, 20);
            this.txt_development.TabIndex = 9;
            // 
            // txt_ui
            // 
            this.txt_ui.Location = new System.Drawing.Point(105, 77);
            this.txt_ui.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_ui.Name = "txt_ui";
            this.txt_ui.Size = new System.Drawing.Size(65, 20);
            this.txt_ui.TabIndex = 8;
            this.txt_ui.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // txt_ux
            // 
            this.txt_ux.Location = new System.Drawing.Point(102, 40);
            this.txt_ux.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_ux.Name = "txt_ux";
            this.txt_ux.Size = new System.Drawing.Size(65, 20);
            this.txt_ux.TabIndex = 7;
            // 
            // lbl_ux
            // 
            this.lbl_ux.AutoSize = true;
            this.lbl_ux.Location = new System.Drawing.Point(18, 47);
            this.lbl_ux.Name = "lbl_ux";
            this.lbl_ux.Size = new System.Drawing.Size(22, 13);
            this.lbl_ux.TabIndex = 6;
            this.lbl_ux.Text = "UX";
            // 
            // lbl_qa
            // 
            this.lbl_qa.AutoSize = true;
            this.lbl_qa.Location = new System.Drawing.Point(31, 163);
            this.lbl_qa.Name = "lbl_qa";
            this.lbl_qa.Size = new System.Drawing.Size(22, 13);
            this.lbl_qa.TabIndex = 2;
            this.lbl_qa.Text = "QA";
            // 
            // lbl_development
            // 
            this.lbl_development.AutoSize = true;
            this.lbl_development.Location = new System.Drawing.Point(18, 118);
            this.lbl_development.Name = "lbl_development";
            this.lbl_development.Size = new System.Drawing.Size(70, 13);
            this.lbl_development.TabIndex = 1;
            this.lbl_development.Text = "Development";
            // 
            // lbl_ui
            // 
            this.lbl_ui.AutoSize = true;
            this.lbl_ui.Location = new System.Drawing.Point(22, 77);
            this.lbl_ui.Name = "lbl_ui";
            this.lbl_ui.Size = new System.Drawing.Size(18, 13);
            this.lbl_ui.TabIndex = 0;
            this.lbl_ui.Text = "UI";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(119, 229);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(134, 20);
            this.dateTimeEnd.TabIndex = 13;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(119, 186);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(134, 20);
            this.dateTimeBegin.TabIndex = 1;
            // 
            // btn_add_project
            // 
            this.btn_add_project.Location = new System.Drawing.Point(66, 528);
            this.btn_add_project.Name = "btn_add_project";
            this.btn_add_project.Size = new System.Drawing.Size(146, 23);
            this.btn_add_project.TabIndex = 12;
            this.btn_add_project.Text = "Add project";
            this.btn_add_project.UseVisualStyleBackColor = true;
            this.btn_add_project.Click += new System.EventHandler(this.btn_add_project_Click);
            // 
            // lbl_teamleaders
            // 
            this.lbl_teamleaders.AutoSize = true;
            this.lbl_teamleaders.Location = new System.Drawing.Point(19, 267);
            this.lbl_teamleaders.Name = "lbl_teamleaders";
            this.lbl_teamleaders.Size = new System.Drawing.Size(66, 13);
            this.lbl_teamleaders.TabIndex = 11;
            this.lbl_teamleaders.Text = "Team leader";
            // 
            // cmbx_team_leader
            // 
            this.cmbx_team_leader.FormattingEnabled = true;
            this.cmbx_team_leader.Location = new System.Drawing.Point(119, 267);
            this.cmbx_team_leader.Name = "cmbx_team_leader";
            this.cmbx_team_leader.Size = new System.Drawing.Size(134, 21);
            this.cmbx_team_leader.TabIndex = 10;
            // 
            // lbl_date_end
            // 
            this.lbl_date_end.AutoSize = true;
            this.lbl_date_end.Location = new System.Drawing.Point(19, 229);
            this.lbl_date_end.Name = "lbl_date_end";
            this.lbl_date_end.Size = new System.Drawing.Size(51, 13);
            this.lbl_date_end.TabIndex = 9;
            this.lbl_date_end.Text = "Date end";
            // 
            // lbl_date_begin
            // 
            this.lbl_date_begin.AutoSize = true;
            this.lbl_date_begin.Location = new System.Drawing.Point(19, 186);
            this.lbl_date_begin.Name = "lbl_date_begin";
            this.lbl_date_begin.Size = new System.Drawing.Size(59, 13);
            this.lbl_date_begin.TabIndex = 8;
            this.lbl_date_begin.Text = "Date begin";
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Location = new System.Drawing.Point(19, 141);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(80, 13);
            this.lbl_customer.TabIndex = 7;
            this.lbl_customer.Text = "Customer name";
            // 
            // lbl_num_hours
            // 
            this.lbl_num_hours.AutoSize = true;
            this.lbl_num_hours.Location = new System.Drawing.Point(19, 94);
            this.lbl_num_hours.Name = "lbl_num_hours";
            this.lbl_num_hours.Size = new System.Drawing.Size(58, 13);
            this.lbl_num_hours.TabIndex = 6;
            this.lbl_num_hours.Text = "Num hours";
            // 
            // txt_customer
            // 
            this.txt_customer.Location = new System.Drawing.Point(119, 141);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(134, 20);
            this.txt_customer.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(119, 48);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(134, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(16, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 600);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_hors)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_development)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txt_num_hors;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown txt_qa;
        private System.Windows.Forms.NumericUpDown txt_development;
        private System.Windows.Forms.NumericUpDown txt_ui;
        private System.Windows.Forms.NumericUpDown txt_ux;
        private System.Windows.Forms.Label lbl_ux;
        private System.Windows.Forms.Label lbl_qa;
        private System.Windows.Forms.Label lbl_development;
        private System.Windows.Forms.Label lbl_ui;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Button btn_add_project;
        private System.Windows.Forms.Label lbl_teamleaders;
        private System.Windows.Forms.ComboBox cmbx_team_leader;
        private System.Windows.Forms.Label lbl_date_end;
        private System.Windows.Forms.Label lbl_date_begin;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label lbl_num_hours;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}