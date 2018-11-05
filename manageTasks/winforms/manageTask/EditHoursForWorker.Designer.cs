namespace manageTask
{
    partial class EditHoursForWorker
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgv_projectHours = new Telerik.WinControls.UI.RadGridView();
            this.lbl_worker = new Telerik.WinControls.UI.RadLabel();
            this.label3 = new Telerik.WinControls.UI.RadLabel();
            this.cmbx_workers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectHours.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_projectHours
            // 
            this.dgv_projectHours.Location = new System.Drawing.Point(266, 124);
            this.dgv_projectHours.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.dgv_projectHours.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgv_projectHours.Name = "dgv_projectHours";
            this.dgv_projectHours.Size = new System.Drawing.Size(596, 432);
            this.dgv_projectHours.TabIndex = 7;
            this.dgv_projectHours.Visible = false;
            // 
            // lbl_worker
            // 
            this.lbl_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_worker.Location = new System.Drawing.Point(134, 67);
            this.lbl_worker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(89, 19);
            this.lbl_worker.TabIndex = 6;
            this.lbl_worker.Text = "Worker name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(463, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edit hours for worker";
            // 
            // cmbx_workers
            // 
            this.cmbx_workers.FormattingEnabled = true;
            this.cmbx_workers.Location = new System.Drawing.Point(266, 78);
            this.cmbx_workers.Name = "cmbx_workers";
            this.cmbx_workers.Size = new System.Drawing.Size(160, 21);
            this.cmbx_workers.TabIndex = 8;
            // 
            // EditHoursForWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 601);
            this.Controls.Add(this.cmbx_workers);
            this.Controls.Add(this.dgv_projectHours);
            this.Controls.Add(this.lbl_worker);
            this.Controls.Add(this.label3);
            this.Name = "EditHoursForWorker";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EditHoursForWorker";
            this.Load += new System.EventHandler(this.EditHoursForWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectHours.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgv_projectHours;
        private Telerik.WinControls.UI.RadLabel lbl_worker;
        private Telerik.WinControls.UI.RadLabel label3;
        private System.Windows.Forms.ComboBox cmbx_workers;
    }
}