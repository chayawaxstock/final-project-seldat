namespace manageTask
{
    partial class AffiliationWorksToTeamLeader
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
            this.lbl_n = new Telerik.WinControls.UI.RadLabel();
            this.lbl_team = new Telerik.WinControls.UI.RadLabel();
            this.btn_workerToTeamleader = new Telerik.WinControls.UI.RadButton();
            this.cmbx_worker = new System.Windows.Forms.ComboBox();
            this.cmbx_team = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_workerToTeamleader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n
            // 
            this.lbl_n.Location = new System.Drawing.Point(12, 85);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(74, 18);
            this.lbl_n.TabIndex = 0;
            this.lbl_n.Text = "Worker name";
            // 
            // lbl_team
            // 
            this.lbl_team.Location = new System.Drawing.Point(282, 85);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(65, 18);
            this.lbl_team.TabIndex = 1;
            this.lbl_team.Text = "Teamleader";
            this.lbl_team.Visible = false;
            // 
            // btn_workerToTeamleader
            // 
            this.btn_workerToTeamleader.Location = new System.Drawing.Point(165, 160);
            this.btn_workerToTeamleader.Name = "btn_workerToTeamleader";
            this.btn_workerToTeamleader.Size = new System.Drawing.Size(214, 23);
            this.btn_workerToTeamleader.TabIndex = 4;
            this.btn_workerToTeamleader.Text = "Affiliation works to team leader";
            this.btn_workerToTeamleader.Visible = false;
            // 
            // cmbx_worker
            // 
            this.cmbx_worker.FormattingEnabled = true;
            this.cmbx_worker.Location = new System.Drawing.Point(92, 85);
            this.cmbx_worker.Name = "cmbx_worker";
            this.cmbx_worker.Size = new System.Drawing.Size(121, 21);
            this.cmbx_worker.TabIndex = 5;
            // 
            // cmbx_team
            // 
            this.cmbx_team.FormattingEnabled = true;
            this.cmbx_team.Location = new System.Drawing.Point(353, 85);
            this.cmbx_team.Name = "cmbx_team";
            this.cmbx_team.Size = new System.Drawing.Size(121, 21);
            this.cmbx_team.TabIndex = 6;
            // 
            // AffiliationWorksToTeamLeader
            // 
            this.ClientSize = new System.Drawing.Size(577, 590);
            this.Controls.Add(this.cmbx_team);
            this.Controls.Add(this.cmbx_worker);
            this.Controls.Add(this.btn_workerToTeamleader);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_n);
            this.Name = "AffiliationWorksToTeamLeader";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.AffiliationWorksToTeamLeader_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_workerToTeamleader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList cmbx_workers;
        private Telerik.WinControls.UI.RadLabel lbl_name;
        private Telerik.WinControls.UI.RadLabel lbl_team_leader;
        private Telerik.WinControls.UI.RadDropDownList cmbx_teamLeaders;
        private Telerik.WinControls.UI.RadLabel lbl_n;
        private Telerik.WinControls.UI.RadLabel lbl_team;
        private Telerik.WinControls.UI.RadButton btn_workerToTeamleader;
        private System.Windows.Forms.ComboBox cmbx_worker;
        private System.Windows.Forms.ComboBox cmbx_team;
    }
}