namespace manageTask
{
    partial class SetTime
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
            this.components = new System.ComponentModel.Container();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cmbx_projects = new System.Windows.Forms.ComboBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_clock.Location = new System.Drawing.Point(755, 180);
            this.lbl_clock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(0, 58);
            this.lbl_clock.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(271, 180);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(91, 17);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Project name";
            // 
            // cmbx_projects
            // 
            this.cmbx_projects.FormattingEnabled = true;
            this.cmbx_projects.Location = new System.Drawing.Point(371, 177);
            this.cmbx_projects.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_projects.Name = "cmbx_projects";
            this.cmbx_projects.Size = new System.Drawing.Size(160, 24);
            this.cmbx_projects.TabIndex = 7;
            this.cmbx_projects.SelectedIndexChanged += new System.EventHandler(this.cmbx_projects_SelectedIndexChanged);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(503, 269);
            this.btn_end.Margin = new System.Windows.Forms.Padding(4);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(100, 28);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Visible = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(278, 269);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 28);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Visible = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 554);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.cmbx_projects);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Name = "SetTime";
            this.Text = "SetTime";
            this.Load += new System.EventHandler(this.SetTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox cmbx_projects;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
    }
}