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
    public partial class ProjectDetails : Form
    {
        public ProjectDetails()
        {
            InitializeComponent();
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            cmbx_projects.Items.Clear();

            List<Project> projects = TaskRequests.getProjectsManager(GlobalProp.CurrentUser.UserId);
            if (projects != null)
            {
                cmbx_projects.DisplayMember = "ProjectName";

                foreach (Project project in projects)
                {

                    cmbx_projects.Items.Add(project);
                }
            }
           
        }

        private void grbx_project_details_Enter(object sender, EventArgs e)
        {

        }

        private void cmbx_projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project project = cmbx_projects.SelectedItem as Project;
            //check wich workers belong to this project

            List<ProjectWorker> projectWorkers = UserLogic.getUserBelongProject(project.ProjectId);
            if (projectWorkers != null)
            {

                dgv_project_details.DataSource = projectWorkers.Select(p => new { p.User.UserName, p.User.Email, p.HoursForProject, p.SumHoursDone }).ToList();
                name_val.Text = projectWorkers[0].Project.ProjectName;
                customer_val.Text = projectWorkers[0].Project.CustomerName;
                hours_val.Text = projectWorkers[0].Project.numHourForProject.ToString();
                date_begin_val.Text = projectWorkers[0].Project.DateBegin.ToString();
                date_end_val.Text = projectWorkers[0].Project.DateEnd.ToString();
                grbx_project_details.Visible = true;


            }
        }

    }
}
