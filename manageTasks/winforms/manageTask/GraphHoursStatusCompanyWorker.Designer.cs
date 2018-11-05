namespace manageTask
{
    partial class GraphHoursStatusCompanyWorker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph_status_hours_for_projects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graph_status_hours_for_projects)).BeginInit();
            this.SuspendLayout();
            // 
            // graph_status_hours_for_projects
            // 
            chartArea3.Name = "ChartArea1";
            this.graph_status_hours_for_projects.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph_status_hours_for_projects.Legends.Add(legend3);
            this.graph_status_hours_for_projects.Location = new System.Drawing.Point(200, 41);
            this.graph_status_hours_for_projects.Margin = new System.Windows.Forms.Padding(4);
            this.graph_status_hours_for_projects.Name = "graph_status_hours_for_projects";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graph_status_hours_for_projects.Series.Add(series3);
            this.graph_status_hours_for_projects.Size = new System.Drawing.Size(400, 369);
            this.graph_status_hours_for_projects.TabIndex = 1;
            this.graph_status_hours_for_projects.Text = "chart1";
            // 
            // GraphHoursStatusCompanyWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 481);
            this.Controls.Add(this.graph_status_hours_for_projects);
            this.Name = "GraphHoursStatusCompanyWorker";
            this.Text = "GraphHoursStatusCompanyWorker";
            this.Load += new System.EventHandler(this.GraphHoursStatusCompanyWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph_status_hours_for_projects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph_status_hours_for_projects;
    }
}