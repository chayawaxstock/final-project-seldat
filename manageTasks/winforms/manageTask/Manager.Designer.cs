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
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.addProjectToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.managmentWorkersToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editWorkersDetailsToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.setPermissionToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.deleteWorkerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addANewWorkerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addWorkerToProjectToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addWorkerToATeamLeaderToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.reportsToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.addProjectToolStripMenuItem,
            this.managmentWorkersToolStripMenuItem,
            this.addWorkerToATeamLeaderToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
           // this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.addProjectToolStripMenuItem.Text = "Add project";
            this.addProjectToolStripMenuItem.Click += this.addProjectToolStripMenuItem_Click;
            // 
            // managmentWorkersToolStripMenuItem
            // 
            this.managmentWorkersToolStripMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
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
            this.editWorkersDetailsToolStripMenuItem.Click += this.editWorkersDetailsToolStripMenuItem_Click;
            // 
            // setPermissionToolStripMenuItem
            // 
            this.setPermissionToolStripMenuItem.Name = "setPermissionToolStripMenuItem";
            this.setPermissionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setPermissionToolStripMenuItem.Text = "Set permission";
            this.setPermissionToolStripMenuItem.Click += this.setPermissionToolStripMenuItem_Click;
            // 
            // deleteWorkerToolStripMenuItem
            // 
            this.deleteWorkerToolStripMenuItem.Name = "deleteWorkerToolStripMenuItem";
            this.deleteWorkerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteWorkerToolStripMenuItem.Text = "Delete worker";
            this.deleteWorkerToolStripMenuItem.Click += this.deleteWorkerToolStripMenuItem_Click;
            // 
            // addANewWorkerToolStripMenuItem
            // 
            this.addANewWorkerToolStripMenuItem.Name = "addANewWorkerToolStripMenuItem";
            this.addANewWorkerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addANewWorkerToolStripMenuItem.Text = "Add a new worker";
            this.addANewWorkerToolStripMenuItem.Click += this.addANewWorkerToolStripMenuItem_Click;
            // 
            // addWorkerToProjectToolStripMenuItem
            // 
            this.addWorkerToProjectToolStripMenuItem.Name = "addWorkerToProjectToolStripMenuItem";
            this.addWorkerToProjectToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addWorkerToProjectToolStripMenuItem.Text = "Add worker to project";
            this.addWorkerToProjectToolStripMenuItem.Click += this.addWorkerToProjectToolStripMenuItem_Click;
            // 
            // addWorkerToATeamLeaderToolStripMenuItem
            // 
            this.addWorkerToATeamLeaderToolStripMenuItem.Name = "addWorkerToATeamLeaderToolStripMenuItem";
            this.addWorkerToATeamLeaderToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.addWorkerToATeamLeaderToolStripMenuItem.Text = "Add worker to a team leader";
            this.addWorkerToATeamLeaderToolStripMenuItem.Click += this.addWorkerToATeamLeaderToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += this.RepotrsToolStripMenuItem_Click;
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
        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem addProjectToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem managmentWorkersToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem editWorkersDetailsToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem setPermissionToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem deleteWorkerToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem addANewWorkerToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem addWorkerToProjectToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem addWorkerToATeamLeaderToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem reportsToolStripMenuItem;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}