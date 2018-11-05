namespace manageTask
{
    partial class SetPermission
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_permission = new System.Windows.Forms.ComboBox();
            this.lbl_permission = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbx_workers
            // 
            this.cmbx_workers.FormattingEnabled = true;
            this.cmbx_workers.Location = new System.Drawing.Point(277, 140);
            this.cmbx_workers.Name = "cmbx_workers";
            this.cmbx_workers.Size = new System.Drawing.Size(121, 21);
            this.cmbx_workers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Workers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a worker to set a permission";
            // 
            // cmbx_permission
            // 
            this.cmbx_permission.FormattingEnabled = true;
            this.cmbx_permission.Location = new System.Drawing.Point(537, 140);
            this.cmbx_permission.Name = "cmbx_permission";
            this.cmbx_permission.Size = new System.Drawing.Size(121, 21);
            this.cmbx_permission.TabIndex = 3;
            this.cmbx_permission.SelectedIndexChanged += new System.EventHandler(this.cmbx_permission_SelectedIndexChanged);
            // 
            // lbl_permission
            // 
            this.lbl_permission.AutoSize = true;
            this.lbl_permission.Location = new System.Drawing.Point(443, 143);
            this.lbl_permission.Name = "lbl_permission";
            this.lbl_permission.Size = new System.Drawing.Size(57, 13);
            this.lbl_permission.TabIndex = 4;
            this.lbl_permission.Text = "Permission";
            // 
            // SetPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_permission);
            this.Controls.Add(this.cmbx_permission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_workers);
            this.Name = "SetPermission";
            this.Text = "Set permission";
            this.Load += new System.EventHandler(this.SetPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_workers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_permission;
        private System.Windows.Forms.Label lbl_permission;
    }
}