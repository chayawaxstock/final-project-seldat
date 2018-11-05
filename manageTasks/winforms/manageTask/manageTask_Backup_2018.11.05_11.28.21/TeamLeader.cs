using manageTask.HelpModel;
using manageTask.Logic;
using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageTask
{
    public partial class TeamLeader : Form
    {
        List<ProjectWorker> tasks;
        ProjectDetails projectDetails = new ProjectDetails();
        GraphHoursStatus graphHoursStatus = new GraphHoursStatus();
        EditHoursForWorker editHours = new EditHoursForWorker();
        public TeamLeader()
        {
           
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {



        }

        //private void TeamLeader_Load(object sender, EventArgs e)
        //{
        //    cmbx_projects.Items.Clear();

        //    List<Project> projects = TaskRequests.getProjectsManager(GlobalProp.CurrentUser.UserId);
        //    if (projects != null)
        //    {
        //        cmbx_projects.DisplayMember = "ProjectName";

        //        foreach (Project project in projects)
        //        {

        //            cmbx_projects.Items.Add(project);
        //        }
        //    }
        //    StatusHours();
        //    getWorkers();

        //}

        //private void cmbx_projects_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Project project = cmbx_projects.SelectedItem as Project;
        //    //check wich workers belong to this project

        //    List<ProjectWorker> projectWorkers = UserLogic.getUserBelongProject(project.ProjectId);
        //    if (projectWorkers != null)
        //    {

        //        dgv_project_details.DataSource = projectWorkers.Select(p => new { p.User.UserName, p.User.Email, p.HoursForProject, p.SumHoursDone }).ToList();
        //        name_val.Text = projectWorkers[0].Project.ProjectName;
        //        customer_val.Text = projectWorkers[0].Project.CustomerName;
        //        hours_val.Text = projectWorkers[0].Project.numHourForProject.ToString();
        //        date_begin_val.Text = projectWorkers[0].Project.DateBegin.ToString();
        //        date_end_val.Text = projectWorkers[0].Project.DateEnd.ToString();
        //        grbx_project_details.Visible = true;


        //    }

        //    //dgv_project_details.DataSource = tasks.Select(p => new { p.ProjectName, p.numHourForProject,p.CustomerName,p.DateBegin,p.DateEnd,p.IsFinish }).ToList();

        //}

        private void grbx_project_details_Enter(object sender, EventArgs e)
        {

        }

        //private void StatusHours()
        //{

        //    Dictionary<string, decimal> workersDictionary = new Dictionary<string, decimal>();

        //    List<SumHoursDoneUser> sumHoursDoneUsers = UserLogic.getSumHoursDoneForUsers();
        //        if (sumHoursDoneUsers != null)
        //        {
        //            cmbx_projects.DisplayMember = "ProjectName";

        //            foreach (SumHoursDoneUser sumHoursDoneUser in sumHoursDoneUsers)
        //            {

        //                workersDictionary.Add(sumHoursDoneUser.Label, sumHoursDoneUser.Data);
        //            }
        //            chart1.Series[0].Points.DataBindXY(workersDictionary.Keys, workersDictionary.Values);
        //        }

            
           
        //}
        //private void getWorkers()
        //{

        //    List<User> workers = UserLogic.getUsersOfTeamLeader(GlobalProp.CurrentUser.UserId);
        //        if (workers != null)
        //        {
        //            cmbx_workers.DisplayMember = "UserName";

        //            foreach (User worker in workers)
        //            {
        //                cmbx_workers.Items.Add(worker);
        //            }


        //        }

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dgv_projectHours.Visible = true;

        //    int userId = (cmbx_workers.SelectedItem as User).UserId;
        //     tasks = TaskRequests.GetAllTasksByUserId(userId);
        //    List<ProjectWithHoursForUser> selectTask  = new List<ProjectWithHoursForUser>();
        //    if (tasks != null)
        //    {
        //        foreach (ProjectWorker item in tasks)
        //        {
        //            selectTask.Add(new ProjectWithHoursForUser { ProjectName = item.Project.ProjectName, NumHoursForProject = item.HoursForProject });
        //        }
        //        dgv_projectHours.DataSource = selectTask;
        //    }


        //}

        //private void Edit_hours(object sender, DataGridViewCellEventArgs e)
        //{
        //  decimal x= Decimal.Parse( dgv_projectHours.Rows[e.RowIndex].Cells["NumHoursForProject"].Value.ToString());
        //    ProjectWorker projectWorker = new ProjectWorker() { UserId = (cmbx_workers.SelectedItem as User).UserId, HoursForProject = x,ProjectId=tasks[e.RowIndex].ProjectId };

        //   if(UserLogic.updateProjectHours(projectWorker))
        //        MessageBox.Show("Success");
        //    else MessageBox.Show("ERROR!!");

        //}

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hours_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_begin_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_end_Click(object sender, EventArgs e)
        {

        }

        private void dgv_projectHours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_worker_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_projectHours_BindingContextChanged(object sender, EventArgs e)
        {

        }

 


        private void projectsDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            projectDetails.MdiParent = this;
            projectDetails.Show();
            projectDetails.WindowState = FormWindowState.Maximized;
        }

        private void graphHoursStatusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            graphHoursStatus.MdiParent = this;
            graphHoursStatus.Show();
            graphHoursStatus.WindowState = FormWindowState.Maximized;
        }

        private void editHoursForWorkerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editHours.MdiParent = this;
            editHours.Show();
            editHours.WindowState = FormWindowState.Maximized;
        }

        private void TeamLeader_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radPanorama1_Click(object sender, EventArgs e)
        {

        }
    }
}
