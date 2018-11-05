namespace manageTask
{
    partial class TeamLeader
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphHoursStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHoursForWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsDetailsToolStripMenuItem,
            this.graphHoursStatusToolStripMenuItem,
            this.editHoursForWorkerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsDetailsToolStripMenuItem
            // 
            this.projectsDetailsToolStripMenuItem.Name = "projectsDetailsToolStripMenuItem";
            this.projectsDetailsToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.projectsDetailsToolStripMenuItem.Text = "Project\'s details";
            this.projectsDetailsToolStripMenuItem.Click += new System.EventHandler(this.projectsDetailsToolStripMenuItem_Click_1);
            // 
            // graphHoursStatusToolStripMenuItem
            // 
            this.graphHoursStatusToolStripMenuItem.Name = "graphHoursStatusToolStripMenuItem";
            this.graphHoursStatusToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.graphHoursStatusToolStripMenuItem.Text = "Graph hours status";
            this.graphHoursStatusToolStripMenuItem.Click += new System.EventHandler(this.graphHoursStatusToolStripMenuItem_Click_1);
            // 
            // editHoursForWorkerToolStripMenuItem
            // 
            this.editHoursForWorkerToolStripMenuItem.Name = "editHoursForWorkerToolStripMenuItem";
            this.editHoursForWorkerToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.editHoursForWorkerToolStripMenuItem.Text = "Edit hours for worker";
            this.editHoursForWorkerToolStripMenuItem.Click += new System.EventHandler(this.editHoursForWorkerToolStripMenuItem_Click_1);
            // 
            // TeamLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 870);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamLeader";
            this.Text = "TeamLeader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphHoursStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHoursForWorkerToolStripMenuItem;
    }
}