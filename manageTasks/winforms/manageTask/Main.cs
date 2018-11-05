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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageTask
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public static Login login = new Login();
        public static b manager = new b();
        public static CompanyWorker companyWorker = new CompanyWorker();
        public static TeamLeader teamLeader = new TeamLeader();
        public void SetName(string name)
        {
            lbl_name.Text = name;
            lbl_name.Visible = false;
        }
        public Main()
        {

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            if (login.MdiParent != this)
                login.MdiParent = this;
            login.Show();
            login.WindowState = FormWindowState.Maximized;
        }

        private void btn_computer_Click(object sender, EventArgs e)
        {
            string computerName = System.Environment.MachineName;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:61309/api/LoginByComputerUser");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string NewUserString = Newtonsoft.Json.JsonConvert.SerializeObject(computerName, Formatting.None);
                    streamWriter.Write(NewUserString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                //Gettting response
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                //Reading response
                using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream(), ASCIIEncoding.ASCII))
                {
                    string result = streamReader.ReadToEnd();
                    //If Login succeeded
                    if (result != null)
                    {
                        MessageBox.Show("login");


                        User user = JsonConvert.DeserializeObject<User>(result);
                        GlobalProp.CurrentUser = user;
                        //UserLogic.checkUser(user.DepartmentUser.Department);



                        if (user.DepartmentUser.Department.ToUpper() == department.MANAGER.ToString())
                        {


                            manager.Show();



                        }

                        else if (user.DepartmentUser.Department.ToUpper() == department.DEVELOPMENT.ToString() || user.DepartmentUser.Department.ToUpper() == department.QA.ToString() || user.DepartmentUser.Department.ToUpper() == department.UI.ToString() || user.DepartmentUser.Department.ToUpper() == department.UX.ToString())
                        {

                            companyWorker.Show();
                            login.Close();
                        }
                        else
                        {

                            teamLeader.Show();
                            login.Close();
                        }

                        System.Windows.Forms.MessageBox.Show(user.DepartmentUser.Department.ToUpper().ToString());


                    }
                    else
                        login.Show();
                    //Printing the matching error

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User is not login, choose another username.");
            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Main")
                    f.Close();
            }



            GlobalProp.CurrentUser = null;




        }
    }
}
