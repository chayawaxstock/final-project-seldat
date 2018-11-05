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
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.label2 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_permission = new Telerik.WinControls.UI.RadLabel();
            this.cmbx_workers = new System.Windows.Forms.ComboBox();
            this.cmbx_permission = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_permission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(213, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Workers";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(292, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a worker to set a permission";
            // 
            // lbl_permission
            // 
            this.lbl_permission.Location = new System.Drawing.Point(443, 143);
            this.lbl_permission.Name = "lbl_permission";
            this.lbl_permission.Size = new System.Drawing.Size(60, 18);
            this.lbl_permission.TabIndex = 4;
            this.lbl_permission.Text = "Permission";
            // 
            // cmbx_workers
            // 
            this.cmbx_workers.FormattingEnabled = true;
            this.cmbx_workers.Location = new System.Drawing.Point(267, 143);
            this.cmbx_workers.Name = "cmbx_workers";
            this.cmbx_workers.Size = new System.Drawing.Size(121, 21);
            this.cmbx_workers.TabIndex = 5;
            // 
            // cmbx_permission
            // 
            this.cmbx_permission.FormattingEnabled = true;
            this.cmbx_permission.Location = new System.Drawing.Point(519, 143);
            this.cmbx_permission.Name = "cmbx_permission";
            this.cmbx_permission.Size = new System.Drawing.Size(121, 21);
            this.cmbx_permission.TabIndex = 6;
            // 
            // SetPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbx_permission);
            this.Controls.Add(this.cmbx_workers);
            this.Controls.Add(this.lbl_permission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetPermission";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Set permission";
            this.Load += new System.EventHandler(this.SetPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_permission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadLabel label2;
        private Telerik.WinControls.UI.RadLabel lbl_permission;
        private System.Windows.Forms.ComboBox cmbx_workers;
        private System.Windows.Forms.ComboBox cmbx_permission;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}