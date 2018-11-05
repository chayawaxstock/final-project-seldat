namespace manageTask
{
    partial class Main
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
            this.btn_sign_in = new Telerik.WinControls.UI.RadButton();
            this.btn_computer = new Telerik.WinControls.UI.RadButton();
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.loginToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.logOutToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.aboutToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.lbl_name = new Telerik.WinControls.UI.RadLabel();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sign_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Location = new System.Drawing.Point(25, 77);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(75, 23);
            this.btn_sign_in.TabIndex = 1;
            this.btn_sign_in.Text = "sign in ";
            this.btn_sign_in.ThemeName = "Fluent";
            // 
            // btn_computer
            // 
            this.btn_computer.Location = new System.Drawing.Point(25, 45);
            this.btn_computer.Name = "btn_computer";
            this.btn_computer.Size = new System.Drawing.Size(172, 23);
            this.btn_computer.TabIndex = 2;
            this.btn_computer.Text = "with user computer";
            this.btn_computer.ThemeName = "Fluent";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Controls.Add(this.lbl_name);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.loginToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 20);
            this.menuStrip1.TabIndex = 4;
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Text = "login";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Text = "logOut";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(1094, 3);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 18);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "hhhhh";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 786);
            this.Controls.Add(this.btn_computer);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Wellcome";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_sign_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_sign_in;
        private Telerik.WinControls.UI.RadButton btn_computer;
        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem loginToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem logOutToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem aboutToolStripMenuItem;
        private Telerik.WinControls.UI.RadLabel lbl_name;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
    }
}