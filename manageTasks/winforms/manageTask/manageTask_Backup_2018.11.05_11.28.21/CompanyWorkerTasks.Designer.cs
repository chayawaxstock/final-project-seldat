namespace manageTask
{
    partial class CompanyWorkerTasks
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
            this.dvg_worker_projects = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_worker_projects)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_worker_projects
            // 
            this.dvg_worker_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_worker_projects.Location = new System.Drawing.Point(101, 27);
            this.dvg_worker_projects.Margin = new System.Windows.Forms.Padding(4);
            this.dvg_worker_projects.Name = "dvg_worker_projects";
            this.dvg_worker_projects.Size = new System.Drawing.Size(601, 428);
            this.dvg_worker_projects.TabIndex = 1;
            // 
            // CompanyWorkerTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dvg_worker_projects);
            this.Name = "CompanyWorkerTasks";
            this.Text = "CompanyWorkerTasks";
            this.Load += new System.EventHandler(this.CompanyWorkerTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_worker_projects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_worker_projects;
    }
}