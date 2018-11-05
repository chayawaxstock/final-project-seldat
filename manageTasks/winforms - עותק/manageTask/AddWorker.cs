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
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            User worker = new User();
            worker.UserName = txt_name.Text;
            string password = txt_password.Text;
            //validation password
            if (password.Length < 4 || password.Length > 4)
            {
                MessageBox.Show("password must contains 4 chars.");
                return;
            }
            //convert password to sha256
            worker.Password = UserLogic.passwordToSHA(txt_password.Text);
            worker.NumHoursWork = num_numHours.Value;
            worker.Email = txt_email.Text;
            worker.DepartmentId = (cmbx_department.SelectedItem as DepartmentUser).Id;

            if (cmbx_teamLeader.Items.Count != 0)
                worker.ManagerId = (cmbx_teamLeader.SelectedItem as User).UserId;
            else
                worker.ManagerId = 0;

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:61309/api/addUser");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string NewUserString = Newtonsoft.Json.JsonConvert.SerializeObject(worker, Formatting.None);
                    streamWriter.Write(NewUserString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                //Gettting response
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                //Reading response
                using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream(), ASCIIEncoding.ASCII))
                {

                    string result = UserLogic.addUser(worker);

                    //If Add succeeded
                    if (result == null)
                    {
                        MessageBox.Show("the worker added");

                    }
                    else MessageBox.Show("ERROR!!!");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error add new worker");
            }
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
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

        private void cmbx_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_teamLeader.Items.Clear();
            if ((cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.DEVELOPMENT.ToString() || (cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.UI.ToString() || (cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.UX.ToString() || (cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.QA.ToString())
            {
                cmbx_teamLeader.Visible = true;
                lbl_team_leader.Visible = true;

                //get all the teamleaders

                List<User> teamLeaders = UserLogic.getUserByDepartment("teamLeader");
                if (teamLeaders != null)
                {
                    cmbx_teamLeader.DisplayMember = "UserName";

                    foreach (User user in teamLeaders)
                    {

                        cmbx_teamLeader.Items.Add(user);
                    }
                }

            }

            else if ((cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.TEAMLEADER.ToString())
            {
                cmbx_teamLeader.Visible = true;
                lbl_team_leader.Visible = true;


                List<User> teamLeaders = UserLogic.getUserByDepartment("manager");
                cmbx_teamLeader.DisplayMember = "UserName";

                foreach (User user in teamLeaders)
                {

                    cmbx_teamLeader.Items.Add(user);
                }

            }


            else if ((cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.MANAGER.ToString())
            {
                cmbx_teamLeader.Visible = false;
                lbl_team_leader.Visible = false;
            }

        }
    }
}

