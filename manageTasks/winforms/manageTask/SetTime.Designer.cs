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
            this.lbl_clock = new Telerik.WinControls.UI.RadLabel();
            this.lbl_name = new Telerik.WinControls.UI.RadLabel();
            this.btn_end = new Telerik.WinControls.UI.RadButton();
            this.btn_start = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbx_projects = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_clock
            // 
            this.lbl_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_clock.Location = new System.Drawing.Point(755, 180);
            this.lbl_clock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(2, 2);
            this.lbl_clock.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(271, 180);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(72, 18);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Project name";
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(503, 269);
            this.btn_end.Margin = new System.Windows.Forms.Padding(4);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(100, 28);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "End";
            this.btn_end.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(278, 269);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 28);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // cmbx_projects
            // 
            this.cmbx_projects.FormattingEnabled = true;
            this.cmbx_projects.Location = new System.Drawing.Point(356, 177);
            this.cmbx_projects.Name = "cmbx_projects";
            this.cmbx_projects.Size = new System.Drawing.Size(121, 21);
            this.cmbx_projects.TabIndex = 10;
            // 
            // SetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 554);
            this.Controls.Add(this.cmbx_projects);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Name = "SetTime";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SetTime";
            this.Load += new System.EventHandler(this.SetTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbl_clock;
        private Telerik.WinControls.UI.RadLabel lbl_name;
        private Telerik.WinControls.UI.RadButton btn_end;
        private Telerik.WinControls.UI.RadButton btn_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbx_projects;
    }
}