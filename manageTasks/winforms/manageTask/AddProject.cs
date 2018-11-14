using manageTask.Logic;
using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace manageTask
{
    public partial class AddProject : Telerik.WinControls.UI.RadForm
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void btn_add_project_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            //create project from text- form
            Project project = GetProject();

            //check validation model
            if (ModelState.IsValid(project))
            {
                radWaitingBar1.Show();
                radWaitingBar1.StartWaiting();
                if (TaskRequests.adddProject(project))
                {
                    RadMessageBox.SetThemeName("materialTeal");
                    RadMessageBox.Show("succsess", "project added", MessageBoxButtons.OK, RadMessageIcon.None, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.SetThemeName("MaterialTeal");
                    RadMessageBox.Show("error add project", "error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                radWaitingBar1.StopWaiting();
                radWaitingBar1.Hide();
            }
            else
            {
                foreach (var item in ModelState.Results)
                {

                    errorProvider1.SetError(gb_addProject.Controls["txt_" + item.MemberNames.ToList()[0]], item.ErrorMessage);
                }
            }
        }

        public Project GetProject()
        {
            Project project = new Project();
            project.ProjectName = txt_ProjectName.Text;
            int numHour;
            if (int.TryParse(txt_numHourForProject.Text, out numHour))
                project.numHourForProject = numHour;
            project.CustomerName = txt_CustomerName.Text;
            project.DateBegin = DateTime.Parse(txt_DateBegin.Text);
            project.DateEnd = DateTime.Parse(txt_DateEnd.Text);
            project.IdManager = (cmbx_team_leader.SelectedItem as User).UserId;
            project.IsFinish = false;
            project.HoursForDepartment = new List<HourForDepartment>();
            //TODO:לעשות את זה דינמי
            project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 2, SumHours = int.Parse(txt_development.Text) });
            project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 3, SumHours = int.Parse(txt_qa.Text) });
            project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 4, SumHours = int.Parse(txt_ui.Text) });
            project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 5, SumHours = int.Parse(txt_ux.Text) });
            project.ProjectId = 0;
            return project;
        }


        private void AddProject_Load(object sender, EventArgs e)
        {
           radWaitingBar1.Hide();
          
         
            //Initialize cmbx_team_leader -get teamLeaders name

            List<User> teamLeaders = UserLogic.getUserByDepartment(GlobalProp.TeamLeaderNameDepartment);
            if (teamLeaders != null)
            {
                cmbx_team_leader.DisplayMember = "UserName";
                cmbx_team_leader.Items.AddRange((teamLeaders.ToArray() as User[]));
                // defualt value
                cmbx_team_leader.SelectedIndex = 0;
                
            }
           
          
        }

        private void dotsRingWaitingBarIndicatorElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
