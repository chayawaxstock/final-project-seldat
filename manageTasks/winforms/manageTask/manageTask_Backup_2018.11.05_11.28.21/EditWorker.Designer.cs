namespace manageTask
{
    partial class EditWorker
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
            this.cmbx_workers = new System.Windows.Forms.ComboBox();
            this.lbl_worker_name = new System.Windows.Forms.Label();
            this.grpb_details = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.numeric_num_hours_work = new System.Windows.Forms.NumericUpDown();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_teamleader = new System.Windows.Forms.Label();
            this.cmbx_teamleader = new System.Windows.Forms.ComboBox();
            this.cmbx_department = new System.Windows.Forms.ComboBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.grpb_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_num_hours_work)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbx_workers
            // 
            this.cmbx_workers.FormattingEnabled = true;
            this.cmbx_workers.Location = new System.Drawing.Point(178, 98);
            this.cmbx_workers.Name = "cmbx_workers";
            this.cmbx_workers.Size = new System.Drawing.Size(121, 21);
            this.cmbx_workers.TabIndex = 0;
            this.cmbx_workers.SelectedIndexChanged += new System.EventHandler(this.cmbx_workers_SelectedIndexChanged);
            // 
            // lbl_worker_name
            // 
            this.lbl_worker_name.AutoSize = true;
            this.lbl_worker_name.Location = new System.Drawing.Point(87, 101);
            this.lbl_worker_name.Name = "lbl_worker_name";
            this.lbl_worker_name.Size = new System.Drawing.Size(74, 13);
            this.lbl_worker_name.TabIndex = 1;
            this.lbl_worker_name.Text = "Worker name:";
            // 
            // grpb_details
            // 
            this.grpb_details.Controls.Add(this.lbl_department);
            this.grpb_details.Controls.Add(this.cmbx_department);
            this.grpb_details.Controls.Add(this.cmbx_teamleader);
            this.grpb_details.Controls.Add(this.lbl_teamleader);
            this.grpb_details.Controls.Add(this.btn_edit);
            this.grpb_details.Controls.Add(this.numeric_num_hours_work);
            this.grpb_details.Controls.Add(this.txt_email);
            this.grpb_details.Controls.Add(this.txt_name);
            this.grpb_details.Controls.Add(this.label4);
            this.grpb_details.Controls.Add(this.label3);
            this.grpb_details.Controls.Add(this.label1);
            this.grpb_details.Location = new System.Drawing.Point(405, 70);
            this.grpb_details.Name = "grpb_details";
            this.grpb_details.Size = new System.Drawing.Size(272, 358);
            this.grpb_details.TabIndex = 2;
            this.grpb_details.TabStop = false;
            this.grpb_details.Text = "Worker\'s details";
            this.grpb_details.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(89, 295);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // numeric_num_hours_work
            // 
            this.numeric_num_hours_work.Location = new System.Drawing.Point(130, 146);
            this.numeric_num_hours_work.Name = "numeric_num_hours_work";
            this.numeric_num_hours_work.Size = new System.Drawing.Size(74, 20);
            this.numeric_num_hours_work.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(104, 107);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(104, 56);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Num hours work:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lbl_teamleader
            // 
            this.lbl_teamleader.AutoSize = true;
            this.lbl_teamleader.Location = new System.Drawing.Point(37, 202);
            this.lbl_teamleader.Name = "lbl_teamleader";
            this.lbl_teamleader.Size = new System.Drawing.Size(60, 13);
            this.lbl_teamleader.TabIndex = 7;
            this.lbl_teamleader.Text = "Teamleade";
            // 
            // cmbx_teamleader
            // 
            this.cmbx_teamleader.FormattingEnabled = true;
            this.cmbx_teamleader.Location = new System.Drawing.Point(121, 193);
            this.cmbx_teamleader.Name = "cmbx_teamleader";
            this.cmbx_teamleader.Size = new System.Drawing.Size(83, 21);
            this.cmbx_teamleader.TabIndex = 8;
            // 
            // cmbx_department
            // 
            this.cmbx_department.FormattingEnabled = true;
            this.cmbx_department.Location = new System.Drawing.Point(121, 236);
            this.cmbx_department.Name = "cmbx_department";
            this.cmbx_department.Size = new System.Drawing.Size(83, 21);
            this.cmbx_department.TabIndex = 9;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(37, 236);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(62, 13);
            this.lbl_department.TabIndex = 10;
            this.lbl_department.Text = "Department";
            // 
            // EditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpb_details);
            this.Controls.Add(this.lbl_worker_name);
            this.Controls.Add(this.cmbx_workers);
            this.Name = "EditWorker";
            this.Text = "Edit worker\'s details";
            this.Load += new System.EventHandler(this.EditWorker_Load);
            this.grpb_details.ResumeLayout(false);
            this.grpb_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_num_hours_work)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_workers;
        private System.Windows.Forms.Label lbl_worker_name;
        private System.Windows.Forms.GroupBox grpb_details;
        private System.Windows.Forms.NumericUpDown numeric_num_hours_work;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.ComboBox cmbx_department;
        private System.Windows.Forms.ComboBox cmbx_teamleader;
        private System.Windows.Forms.Label lbl_teamleader;
    }
}