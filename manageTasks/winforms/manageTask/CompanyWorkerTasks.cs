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
    public partial class CompanyWorkerTasks : Telerik.WinControls.UI.RadForm
    {
        public CompanyWorkerTasks()
        {
            InitializeComponent();
        }

        private void CompanyWorkerTasks_Load(object sender, EventArgs e)
        {


            List<ProjectWorker> projects = TaskRequests.getProjectsById(GlobalProp.CurrentUser.UserId);

            if (projects != null)
            {
                dvg_worker_projects.DataSource = projects.Select(p => new { p.Project.ProjectName, p.HoursForProject, p.SumHoursDone }).ToList();

            }

        }
    }
}
