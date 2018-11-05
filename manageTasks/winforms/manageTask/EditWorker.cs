using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using manageTask.Logic;
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
    public partial class EditWorker : Telerik.WinControls.UI.RadForm
    {
        public EditWorker()
        {


            InitializeComponent();
        }


        private void EditWorker_Load(object sender, EventArgs e)
        {
            List<User> workers = UserLogic.getAllUsers();
            if (workers != null)
            {
                cmbx_workers.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    cmbx_workers.Items.Add(worker);
                }
            }


            cmbx_teamleader.Items.Clear();
            List<User> teamLeaders = UserLogic.getUserByDepartment("teamLeader");
            if (teamLeaders != null)
            {
                cmbx_teamleader.DisplayMember = "UserName";

                foreach (User user in teamLeaders)
                {

                    cmbx_teamleader.Items.Add(user);
                }
            }

            //get all the department

            List<DepartmentUser> departments = UserLogic.getAllDepartments();
            if (departments != null)
            {
                cmbx_department.DisplayMember = "Department";
                foreach (DepartmentUser department in departments)
                {
                    cmbx_department.Items.Add(department);
                }
            }

        }

        private void cmbx_workers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teamleaderName;
            grpb_details.Visible = true;
            txt_name.Text = (cmbx_workers.SelectedItem as User).UserName;
            txt_email.Text = (cmbx_workers.SelectedItem as User).Email;
            numeric_num_hours_work.Value = (cmbx_workers.SelectedItem as User).NumHoursWork;
            cmbx_department.Text = (cmbx_workers.SelectedItem as User).DepartmentUser.Department;
            foreach (User item in cmbx_teamleader.Items)
            {
                if (item.UserId == (cmbx_workers.SelectedItem as User).ManagerId)
                {
                    teamleaderName = item.UserName;
                    cmbx_teamleader.Text = teamleaderName;
                }
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            User editUser = new User();
            editUser = (cmbx_workers.SelectedItem as User);
            editUser.UserName = txt_name.Text;
            editUser.Email = txt_email.Text;
            editUser.Password = UserLogic.passwordToSHA("example string");
            editUser.NumHoursWork = numeric_num_hours_work.Value;
            editUser.ManagerId = (cmbx_teamleader.SelectedItem as User).UserId;
            editUser.DepartmentId = (cmbx_department.SelectedItem as DepartmentUser).Id;

            try
            {

                var httpResponse = UserLogic.updateUser(editUser);
                if (httpResponse.StatusDescription == "OK")
                {
                    MessageBox.Show("Success");
                    cmbx_workers.Items.Clear();
                    List<User> workers = UserLogic.getAllUsers();
                    if (workers != null)
                    {
                        cmbx_workers.DisplayMember = "UserName";
                        foreach (User worker in workers)
                        {
                            cmbx_workers.Items.Add(worker);
                        }
                    }
                }
                else MessageBox.Show("ERROR!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR cant edit the worker!!!");
            }

        }


    }
}
