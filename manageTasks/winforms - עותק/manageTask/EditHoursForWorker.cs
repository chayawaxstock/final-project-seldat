using manageTask.HelpModel;
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
    public partial class EditHoursForWorker : Form
    {
        List<ProjectWorker> tasks;
        public EditHoursForWorker()
        {
            InitializeComponent();
        }

        private void EditHoursForWorker_Load(object sender, EventArgs e)
        {
            List<User> workers = UserLogic.getUsersOfTeamLeader(GlobalProp.CurrentUser.UserId);
            if (workers != null)
            {
                cmbx_workers.DisplayMember = "UserName";

                foreach (User worker in workers)
                {
                    cmbx_workers.Items.Add(worker);
                }


            }
        }

        private void cmbx_workers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_projectHours.Visible = true;

            int userId = (cmbx_workers.SelectedItem as User).UserId;
            tasks = TaskRequests.GetAllTasksByUserId(userId);
            List<ProjectWithHoursForUser> selectTask = new List<ProjectWithHoursForUser>();
            if (tasks != null)
            {
                foreach (ProjectWorker item in tasks)
                {
                    selectTask.Add(new ProjectWithHoursForUser { ProjectName = item.Project.ProjectName, NumHoursForProject = item.HoursForProject });
                }
                dgv_projectHours.DataSource = selectTask;
            }
        }
        private void Edit_hours(object sender, DataGridViewCellEventArgs e)
        {
            decimal x = Decimal.Parse(dgv_projectHours.Rows[e.RowIndex].Cells["NumHoursForProject"].Value.ToString());
            ProjectWorker projectWorker = new ProjectWorker() { UserId = (cmbx_workers.SelectedItem as User).UserId, HoursForProject = x, ProjectId = tasks[e.RowIndex].ProjectId };

            if (UserLogic.updateProjectHours(projectWorker))
                MessageBox.Show("Success");
            else MessageBox.Show("ERROR!!");

        }
    }
}
