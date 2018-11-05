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
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            Telerik.WinControls.ThemeSource themeSource2 = new Telerik.WinControls.ThemeSource();
            Telerik.WinControls.ThemeSource themeSource3 = new Telerik.WinControls.ThemeSource();
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.projectsDetailsToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.graphHoursStatusToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editHoursForWorkerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.rad = new Telerik.WinControls.RadThemeManager();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.projectsDetailsToolStripMenuItem,
            this.graphHoursStatusToolStripMenuItem,
            this.editHoursForWorkerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1582, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsDetailsToolStripMenuItem
            // 
            this.projectsDetailsToolStripMenuItem.Name = "projectsDetailsToolStripMenuItem";
            this.projectsDetailsToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.projectsDetailsToolStripMenuItem.Text = "Project\'s details";
            this.projectsDetailsToolStripMenuItem.Click += this.projectsDetailsToolStripMenuItem_Click_1;
            // 
            // graphHoursStatusToolStripMenuItem
            // 
            this.graphHoursStatusToolStripMenuItem.Name = "graphHoursStatusToolStripMenuItem";
            this.graphHoursStatusToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.graphHoursStatusToolStripMenuItem.Text = "Graph hours status";
            this.graphHoursStatusToolStripMenuItem.Click += this.graphHoursStatusToolStripMenuItem_Click_1;
            // 
            // editHoursForWorkerToolStripMenuItem
            // 
            this.editHoursForWorkerToolStripMenuItem.Name = "editHoursForWorkerToolStripMenuItem";
            this.editHoursForWorkerToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.editHoursForWorkerToolStripMenuItem.Text = "Edit hours for worker";
            this.editHoursForWorkerToolStripMenuItem.Click += this.editHoursForWorkerToolStripMenuItem_Click_1;
            // 
            // rad
            // 
            this.rad.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1,
            themeSource2});
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton1.Location = new System.Drawing.Point(252, 415);
            this.radButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 165, 36);
            this.radButton1.Size = new System.Drawing.Size(165, 37);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "radButton1";
            this.radButton1.ThemeName = "Office2010Silver";
            // 
            // radThemeManager1
            // 
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource3});
            // 
            // radPanorama1
            // 
            this.radPanorama1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radPanorama1.CellSize = new System.Drawing.Size(150, 154);
            this.radPanorama1.Location = new System.Drawing.Point(88, 82);
            this.radPanorama1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radPanorama1.Name = "radPanorama1";
            // 
            // 
            // 
            this.radPanorama1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 360, 225);
            this.radPanorama1.ScrollBarThickness = 24;
            this.radPanorama1.Size = new System.Drawing.Size(1288, 531);
            this.radPanorama1.TabIndex = 5;
            this.radPanorama1.ThemeName = "Office2010Silver";
            this.radPanorama1.Click += this.radPanorama1_Click;
            // 
            // TeamLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1050);
            this.Controls.Add(this.radPanorama1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamLeader";
            this.Text = "TeamLeader";
            this.Load += new System.EventHandler(this.TeamLeader_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem projectsDetailsToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem graphHoursStatusToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem editHoursForWorkerToolStripMenuItem;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.RadThemeManager rad;
    }
}