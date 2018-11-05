using manageTask.Logic;
using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageTask
{
    public partial class DeleteWorker : Telerik.WinControls.UI.RadForm
    {
        public DeleteWorker()
        {
            InitializeComponent();
        }

        private void DeleteWorker_Load(object sender, EventArgs e)
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

        }

        private void cmbx_workers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userId = (cmbx_workers.SelectedItem as User).UserId;
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var client = new HttpClient())
                {

                    var response = UserLogic.deleteUser(userId);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Success");
                        cmbx_workers.Items.Remove(cmbx_workers.SelectedItem);
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}
