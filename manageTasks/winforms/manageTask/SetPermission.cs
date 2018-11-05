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
    public partial class SetPermission : Telerik.WinControls.UI.RadForm
    {
        public SetPermission()
        {
            InitializeComponent();
        }

        private void SetPermission_Load(object sender, EventArgs e)
        {


            List<User> workers = UserRequests.getSimpleWorkers();
            if (workers != null)

            {
                cmbx_workers.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    cmbx_workers.Items.Add(worker);
                }


            }


            //get all the department
            List<DepartmentUser> departments = UserLogic.getAllDepartments();
            if (departments != null)
            {
                cmbx_permission.DisplayMember = "Department";
                foreach (DepartmentUser department in departments)
                {
                    cmbx_permission.Items.Add(department);
                }
            }

        }



        private void cmbx_permission_SelectedIndexChanged(object sender, EventArgs e)
        {
            User userToUpdate = new User();
            int userId = (cmbx_workers.SelectedItem as User).UserId;
            var confirmResult = MessageBox.Show($"Are you sure you want to change the permission to {(cmbx_permission.SelectedItem as DepartmentUser).Department}??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                userToUpdate = (cmbx_workers.SelectedItem as User);
                userToUpdate.DepartmentId = (cmbx_permission.SelectedItem as DepartmentUser).Id;
                try
                {

                    var httpResponse = UserLogic.updateUser(userToUpdate);
                    if (httpResponse.StatusDescription == "OK")
                        MessageBox.Show("Success");
                    else MessageBox.Show("ERROR!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("cant set the premmision");
                }
            }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}
