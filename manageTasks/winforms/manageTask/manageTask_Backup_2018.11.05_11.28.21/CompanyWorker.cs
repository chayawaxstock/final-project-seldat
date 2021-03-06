﻿using manageTask.HelpModel;
using manageTask.Logic;
using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageTask
{
    public partial class CompanyWorker : Form
    {
        //List<ProjectWorker> projects;
        SetTime setTime = new SetTime();
        GraphHoursStatusCompanyWorker graphHours = new GraphHoursStatusCompanyWorker();
        ContactManager contactManager = new ContactManager();
        CompanyWorkerTasks workerTasks = new CompanyWorkerTasks();
        public CompanyWorker()
        {
            InitializeComponent();
        }
        //private void CompanyWorker_Load(object sender, EventArgs e)
        //{
        //     projects = TaskRequests.getProjectsById(GlobalProp.CurrentUser.UserId);
        //    if (projects != null)
        //    {
        //        cmbx_projects.DisplayMember = "ProjectName";

        //        foreach (ProjectWorker project in projects)
        //        {

        //            cmbx_projects.Items.Add(project.Project);
        //        }
        //    }

        //    dvg_worker_projects.DataSource = projects.Select(p => new {p.Project.ProjectName, p.HoursForProject, p.SumHoursDone }).ToList();
        //    StatusHours();

        //}
        //private void tabPage1_Click(object sender, EventArgs e)
        //{
           
        //}

      // public static TimeSpan d = new TimeSpan(00, 00, 0000);
      //public static  TimeSpan time1 = TimeSpan.FromSeconds(1);
      //  private void timer1_Tick(object sender, EventArgs e)
      //      {
          
      //      d= d.Add(time1);
      //      lbl_clock.Text = d.ToString();
      //      }

      //  private void cmbx_projects_SelectedIndexChanged(object sender, EventArgs e)
      //  {
      //      btn_start.Visible = true;
      //      btn_end.Visible = true;
      //  }

      //  private void btn_start_Click(object sender, EventArgs e)
      //  {
      //      timer1.Enabled = true;
      //      //btn_end.Visible = true;
      //      //btn_start.Visible = false;
      //      PresentDay p = new PresentDay();
      //      p.UserId = GlobalProp.CurrentUser.UserId;
      //      p.ProjectId = (cmbx_projects.SelectedItem as Project).ProjectId;
      //      DateTime d = DateTime.Now;
      //      p.TimeBegin = d;
      //      p.TimeEnd = d;

      //    if(  PresentDayRequests.addPresentDay(p))
      //          MessageBox.Show("Start");
      //      else MessageBox.Show("Error");
      //  }

      //  private void btn_end_Click(object sender, EventArgs e)
      //  {
      //      timer1.Enabled = false;
      //      PresentDay p = new PresentDay();
      //      p.UserId = GlobalProp.CurrentUser.UserId;
      //      p.ProjectId = (cmbx_projects.SelectedItem as Project).ProjectId;
      //      p.TimeEnd = DateTime.Now;

      //      if (PresentDayRequests.updatePresentDay(p))
      //          MessageBox.Show("End");
      //      else MessageBox.Show("Error");

      //  }

        //private void btn_send_message_Click(object sender, EventArgs e)
        //{

        //    SendEmail sendMassage=new SendEmail();
        //    sendMassage.message=richTextBoxMessage.Text;
        //    if (UserRequests.sendMessage(GlobalProp.CurrentUser.UserId,sendMassage))
        //        MessageBox.Show("The message send");
        //    else MessageBox.Show("ERROR not send");
        //}

        //private void StatusHours()
        //{
        //    Dictionary<string, decimal> projectsDictionary = TaskRequests.getHoursUsersProject();
        //    graph_status_hours_for_projects.Series[0].Points.DataBindXY(projectsDictionary.Keys, projectsDictionary.Values);
        //}

        private void setTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTime.MdiParent = this;
            setTime.Show();
            setTime.WindowState = FormWindowState.Maximized;
        }

        private void graphHoursStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphHours.MdiParent = this;
            graphHours.Show();
            graphHours.WindowState = FormWindowState.Maximized;
        }

        private void cotactTheManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            contactManager.MdiParent = this;
            contactManager.Show();
            contactManager.WindowState = FormWindowState.Maximized;
            
        }

        private void yourTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workerTasks.MdiParent = this;
            workerTasks.Show();
            workerTasks.WindowState = FormWindowState.Maximized;
        }
    }
}
