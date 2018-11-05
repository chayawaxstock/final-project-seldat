namespace manageTask
{
    partial class DeleteWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_workers = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the worker you want to delete";
            // 
            // cmbx_workers
            // 
            this.cmbx_workers.FormattingEnabled = true;
            this.cmbx_workers.Location = new System.Drawing.Point(380, 149);
            this.cmbx_workers.Name = "cmbx_workers";
            this.cmbx_workers.Size = new System.Drawing.Size(121, 21);
            this.cmbx_workers.TabIndex = 1;
            this.cmbx_workers.SelectedIndexChanged += new System.EventHandler(this.cmbx_workers_SelectedIndexChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(300, 152);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Worker name:";
            // 
            // DeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.cmbx_workers);
            this.Controls.Add(this.label1);
            this.Name = "DeleteWorker";
            this.Text = "Delete worker";
            this.Load += new System.EventHandler(this.DeleteWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_workers;
        private System.Windows.Forms.Label lbl_name;
    }
}