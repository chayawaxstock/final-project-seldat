namespace manageTask
{
    partial class AddWorkerToProject
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
            this.lbl_worker = new System.Windows.Forms.Label();
            this.cmbx_projects = new System.Windows.Forms.ComboBox();
            this.lbl_project = new System.Windows.Forms.Label();
            this.btn_addProjectToWorker = new System.Windows.Forms.Button();
            this.checkedListBoxWorkers = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbl_worker
            // 
            this.lbl_worker.AutoSize = true;
            this.lbl_worker.Location = new System.Drawing.Point(152, 57);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(42, 13);
            this.lbl_worker.TabIndex = 1;
            this.lbl_worker.Text = "Worker";
            // 
            // cmbx_projects
            // 
            this.cmbx_projects.FormattingEnabled = true;
            this.cmbx_projects.Location = new System.Drawing.Point(395, 83);
            this.cmbx_projects.Name = "cmbx_projects";
            this.cmbx_projects.Size = new System.Drawing.Size(121, 21);
            this.cmbx_projects.TabIndex = 2;
            this.cmbx_projects.SelectedIndexChanged += new System.EventHandler(this.cmbx_projects_SelectedIndexChanged);
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Location = new System.Drawing.Point(339, 88);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(40, 13);
            this.lbl_project.TabIndex = 3;
            this.lbl_project.Text = "Project";
            // 
            // btn_addProjectToWorker
            // 
            this.btn_addProjectToWorker.Location = new System.Drawing.Point(258, 363);
            this.btn_addProjectToWorker.Name = "btn_addProjectToWorker";
            this.btn_addProjectToWorker.Size = new System.Drawing.Size(236, 23);
            this.btn_addProjectToWorker.TabIndex = 4;
            this.btn_addProjectToWorker.Text = "Add the project to the worker";
            this.btn_addProjectToWorker.UseVisualStyleBackColor = true;
            this.btn_addProjectToWorker.Visible = false;
            this.btn_addProjectToWorker.Click += new System.EventHandler(this.btn_addProjectToWorker_Click);
            // 
            // checkedListBoxWorkers
            // 
            this.checkedListBoxWorkers.FormattingEnabled = true;
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(120, 83);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(120, 214);
            this.checkedListBoxWorkers.TabIndex = 5;
            // 
            // AddWorkerToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 475);
            this.Controls.Add(this.checkedListBoxWorkers);
            this.Controls.Add(this.btn_addProjectToWorker);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.cmbx_projects);
            this.Controls.Add(this.lbl_worker);
            this.Name = "AddWorkerToProject";
            this.Text = "Add a worker to a project";
            this.Load += new System.EventHandler(this.AddWorkerToProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_worker;
        private System.Windows.Forms.ComboBox cmbx_projects;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Button btn_addProjectToWorker;
        private System.Windows.Forms.CheckedListBox checkedListBoxWorkers;
    }
}