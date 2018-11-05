using manageTask.Logic;
using manageTask.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace manageTask
{
    public partial class b : Telerik.WinControls.UI.RadForm
    {
        List<string> teamLeaders = new List<string>();
        AddWorker addWorker = new AddWorker();
        DeleteWorker deleteWorker = new DeleteWorker();
        SetPermission setPermission = new SetPermission();
        EditWorker editWorker = new EditWorker();
        AddWorkerToProject addWorkerToProject = new AddWorkerToProject();
        AffiliationWorksToTeamLeader affiliationWorksToTeamLeader = new AffiliationWorksToTeamLeader();
        AddProject addProject = new AddProject();
        Reports reports = new Reports();

        public b()
        {

            InitializeComponent();
        }

        private void cmbx_team_leader_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            //tabControl_SelectedIndexChanged(sender, e);
            //this.reportViewer1.RefreshReport();
        }

        //private void btn_add_project_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show($"ui{ txt_ui.Value}");
        //    MessageBox.Show($"hors{txt_num_hors.Value}");

        //    if (txt_development.Value + txt_qa.Value + txt_ui.Value + txt_ux.Value > txt_num_hors.Value)
        //    {
        //        MessageBox.Show("sum hours greater than hours for project please change it");
        //        return;
        //    }

        //    Project project = new Project();
        //    project.ProjectName = txt_name.Text;
        //    project.numHourForProject = int.Parse(txt_num_hors.Text);
        //    project.CustomerName = txt_customer.Text;
        //    project.DateBegin = DateTime.Parse(dateTimeBegin.Text);
        //    project.DateEnd = DateTime.Parse(dateTimeEnd.Text);
        //    project.IdManager = (cmbx_team_leader.SelectedItem as User).UserId;
        //    project.IsFinish = false;
        //    project.HoursForDepartment = new List<HourForDepartment>();
        //    project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 2, SumHours = int.Parse(txt_development.Text) });
        //    project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 3, SumHours = int.Parse(txt_qa.Text) });
        //    project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 4, SumHours = int.Parse(txt_ui.Text) });
        //    project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 5, SumHours = int.Parse(txt_ux.Text) });
        //    project.ProjectId = 0;


        //    if (TaskRequests.adddProject(project))
        //        MessageBox.Show("the project added");
        //    else MessageBox.Show("error add new project");
        //}




        //private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabControl.SelectedTab == tabControl.TabPages[0])
        //    //Request via GET-getAllTeamLeader
        //    {

        //        List<User> teamLeaders = UserLogic.getUserByDepartment("teamLeader");
        //        if (teamLeaders != null)
        //        {
        //            cmbx_team_leader.DisplayMember = "UserName";

        //            foreach (User user in teamLeaders)
        //            {

        //                cmbx_team_leader.Items.Add(user);
        //            }
        //        }



        //    }
        //}

        private void editWorkersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editWorker.MdiParent = this;
            editWorker.Show();
            editWorker.WindowState = FormWindowState.Maximized;
        }

        private void setPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPermission.MdiParent = this;
            setPermission.Show();
            setPermission.WindowState = FormWindowState.Maximized;
        }

        private void deleteWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteWorker.MdiParent = this;
            deleteWorker.Show();
            deleteWorker.WindowState = FormWindowState.Maximized;
        }

        private void addANewWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addWorker.MdiParent = this;
            addWorker.Show();
            addWorker.WindowState = FormWindowState.Maximized;
        }

        private void addWorkerToProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addWorkerToProject.MdiParent = this;
            addWorkerToProject.Show();
            addWorkerToProject.WindowState = FormWindowState.Maximized;
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProject.MdiParent = this;
            addProject.Show();
            addProject.WindowState = FormWindowState.Maximized;
        }

        private void addWorkerToATeamLeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affiliationWorksToTeamLeader.MdiParent = this;
            affiliationWorksToTeamLeader.Show();
            affiliationWorksToTeamLeader.WindowState = FormWindowState.Maximized;
        }

        private void RepotrsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.MdiParent = this;
            reports.Show();
            reports.WindowState = FormWindowState.Maximized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        //private void reportViewer1_Load(object sender, EventArgs e)
        //{
        //    reportViewer1.ProcessingMode = ProcessingMode.Local;

        //    LocalReport localReport = reportViewer1.LocalReport;

        //    localReport.ReportPath = "Sales Order Detail.rdlc";

        //    DataSet dataset = new DataSet("Sales Order Detail");

        //    string salesOrderNumber = "SO43661";

        //    // Get the sales order data  
        //    GetSalesOrderData(salesOrderNumber, ref dataset);

        //    // Create a report data source for the sales order data  
        //    ReportDataSource dsSalesOrder = new ReportDataSource();
        //    dsSalesOrder.Name = "SalesOrder";
        //    dsSalesOrder.Value = dataset.Tables["SalesOrder"];

        //    localReport.DataSources.Add(dsSalesOrder);

        //    // Get the sales order detail data  
        //    GetSalesOrderDetailData(salesOrderNumber, ref dataset);

        //    // Create a report data source for the sales order detail   
        //    // data  
        //    ReportDataSource dsSalesOrderDetail =
        //        new ReportDataSource();
        //    dsSalesOrderDetail.Name = "SalesOrderDetail";
        //    dsSalesOrderDetail.Value =
        //        dataset.Tables["SalesOrderDetail"];

        //    localReport.DataSources.Add(dsSalesOrderDetail);

        //    // Create a report parameter for the sales order number   
        //    ReportParameter rpSalesOrderNumber = new ReportParameter();
        //    rpSalesOrderNumber.Name = "SalesOrderNumber";
        //    rpSalesOrderNumber.Values.Add("SO43661");

        //    // Set the report parameters for the report  
        //    localReport.SetParameters(
        //        new ReportParameter[] { rpSalesOrderNumber });

        //    // Refresh the report  
        //    reportViewer1.RefreshReport();
        //}
    }
}
