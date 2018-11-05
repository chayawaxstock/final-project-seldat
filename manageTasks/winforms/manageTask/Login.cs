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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace manageTask
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public static b manager = new b();
        public static CompanyWorker companyWorker = new CompanyWorker();
        public static TeamLeader teamLeader = new TeamLeader();
        public static Main main = new Main();

        public Login()
        {


            InitializeComponent();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            dynamic NewUser;
            //Try converting age.
            try
            {
                //Validations 
                string userName = txt_userName.Text;
                if (userName.Length < 2 || userName.Length > 15)
                {
                    MessageBox.Show("User name must contains 2 - 15 chars.");
                    return;
                }

                string password = txt_password.Text;
                if (password.Length < 4 || password.Length > 4)
                {
                    MessageBox.Show("password must contains 6 chars.");
                    return;
                }

                string newPassword = UserLogic.passwordToSHA(txt_password.Text);

                //Post Request for Login
                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:61309/api/loginByPassword");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        NewUser = new User { UserName = txt_userName.Text, Password = newPassword };
                        string NewUserString = Newtonsoft.Json.JsonConvert.SerializeObject(NewUser, Formatting.None);
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

                            User user = JsonConvert.DeserializeObject<User>(result);
                            GlobalProp.CurrentUser = user;




                            if (user.DepartmentUser.Department.ToUpper() == department.MANAGER.ToString())
                            {


                                manager.Show();
                                Close();


                            }

                            else if (user.DepartmentUser.Department.ToUpper() == department.DEVELOPMENT.ToString() || user.DepartmentUser.Department.ToUpper() == department.QA.ToString() || user.DepartmentUser.Department.ToUpper() == department.UI.ToString() || user.DepartmentUser.Department.ToUpper() == department.UX.ToString())
                            {

                                companyWorker.Show();
                                Close();
                            }
                            else
                            {

                                teamLeader.Show();
                                Close();
                            }

                            System.Windows.Forms.MessageBox.Show(user.DepartmentUser.Department.ToUpper().ToString());
                            main.SetName(GlobalProp.CurrentUser.UserName);
                        }
                        //Printing the matching error
                        else MessageBox.Show(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User is not login, choose another username.");
                }
            }
            catch
            {
                MessageBox.Show("NOT GOOD");
            }

        }
    }
}
