namespace manageTask
{
    partial class b
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWorkersDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkerToProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkerToATeamLeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.managmentWorkersToolStripMenuItem,
            this.addWorkerToATeamLeaderToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.addProjectToolStripMenuItem.Text = "Add project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // managmentWorkersToolStripMenuItem
            // 
            this.managmentWorkersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editWorkersDetailsToolStripMenuItem,
            this.setPermissionToolStripMenuItem,
            this.deleteWorkerToolStripMenuItem,
            this.addANewWorkerToolStripMenuItem,
            this.addWorkerToProjectToolStripMenuItem});
            this.managmentWorkersToolStripMenuItem.Name = "managmentWorkersToolStripMenuItem";
            this.managmentWorkersToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.managmentWorkersToolStripMenuItem.Text = "Managment workers";
            // 
            // editWorkersDetailsToolStripMenuItem
            // 
            this.editWorkersDetailsToolStripMenuItem.Name = "editWorkersDetailsToolStripMenuItem";
            this.editWorkersDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editWorkersDetailsToolStripMenuItem.Text = "Edit worker\'s details";
            this.editWorkersDetailsToolStripMenuItem.Click += new System.EventHandler(this.editWorkersDetailsToolStripMenuItem_Click);
            // 
            // setPermissionToolStripMenuItem
            // 
            this.setPermissionToolStripMenuItem.Name = "setPermissionToolStripMenuItem";
            this.setPermissionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setPermissionToolStripMenuItem.Text = "Set permission";
            this.setPermissionToolStripMenuItem.Click += new System.EventHandler(this.setPermissionToolStripMenuItem_Click);
            // 
            // deleteWorkerToolStripMenuItem
            // 
            this.deleteWorkerToolStripMenuItem.Name = "deleteWorkerToolStripMenuItem";
            this.deleteWorkerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteWorkerToolStripMenuItem.Text = "Delete worker";
            this.deleteWorkerToolStripMenuItem.Click += new System.EventHandler(this.deleteWorkerToolStripMenuItem_Click);
            // 
            // addANewWorkerToolStripMenuItem
            // 
            this.addANewWorkerToolStripMenuItem.Name = "addANewWorkerToolStripMenuItem";
            this.addANewWorkerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addANewWorkerToolStripMenuItem.Text = "Add a new worker";
            this.addANewWorkerToolStripMenuItem.Click += new System.EventHandler(this.addANewWorkerToolStripMenuItem_Click);
            // 
            // addWorkerToProjectToolStripMenuItem
            // 
            this.addWorkerToProjectToolStripMenuItem.Name = "addWorkerToProjectToolStripMenuItem";
            this.addWorkerToProjectToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addWorkerToProjectToolStripMenuItem.Text = "Add worker to project";
            this.addWorkerToProjectToolStripMenuItem.Click += new System.EventHandler(this.addWorkerToProjectToolStripMenuItem_Click);
            // 
            // addWorkerToATeamLeaderToolStripMenuItem
            // 
            this.addWorkerToATeamLeaderToolStripMenuItem.Name = "addWorkerToATeamLeaderToolStripMenuItem";
            this.addWorkerToATeamLeaderToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.addWorkerToATeamLeaderToolStripMenuItem.Text = "Add worker to a team leader";
            this.addWorkerToATeamLeaderToolStripMenuItem.Click += new System.EventHandler(this.addWorkerToATeamLeaderToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.RepotrsToolStripMenuItem_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(172, 166);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "radButton1";
            this.radButton1.ThemeName = "btn";
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 684);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "b";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managmentWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWorkersDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkerToProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkerToATeamLeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}