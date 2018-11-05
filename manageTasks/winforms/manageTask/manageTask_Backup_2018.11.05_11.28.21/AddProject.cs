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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void btn_add_project_Click(object sender, EventArgs e)
        {
           


                if (txt_development.Value + txt_qa.Value + txt_ui.Value + txt_ux.Value > txt_num_hors.Value)
                {
                    MessageBox.Show("sum hours greater than hours for project please change it");
                    return;
                }

                Project project = new Project();
                project.ProjectName = txt_name.Text;
                project.numHourForProject = int.Parse(txt_num_hors.Text);
                project.CustomerName = txt_customer.Text;
                project.DateBegin = DateTime.Parse(dateTimeBegin.Text);
                project.DateEnd = DateTime.Parse(dateTimeEnd.Text);
                project.IdManager = (cmbx_team_leader.SelectedItem as User).UserId;
                project.IsFinish = false;
                project.HoursForDepartment = new List<HourForDepartment>();
                project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 2, SumHours = int.Parse(txt_development.Text) });
                project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 3, SumHours = int.Parse(txt_qa.Text) });
                project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 4, SumHours = int.Parse(txt_ui.Text) });
                project.HoursForDepartment.Add(new HourForDepartment() { DepartmentId = 5, SumHours = int.Parse(txt_ux.Text) });
                project.ProjectId = 0;


                if (TaskRequests.adddProject(project))
                    MessageBox.Show("the project added");
                else MessageBox.Show("error add new project");
            
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
