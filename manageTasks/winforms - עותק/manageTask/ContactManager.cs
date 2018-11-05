using manageTask.HelpModel;
using manageTask.Logic;
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
    public partial class ContactManager : Form
    {
        public ContactManager()
        {
            InitializeComponent();
        }

        private void btn_send_message_Click(object sender, EventArgs e)
        {

            SendEmail sendMassage = new SendEmail();
            sendMassage.message = richTextBoxMessage.Text;
            if (UserRequests.sendMessage(GlobalProp.CurrentUser.UserId, sendMassage))
                MessageBox.Show("The message send");
            else MessageBox.Show("ERROR not send");
        }
    }
}
