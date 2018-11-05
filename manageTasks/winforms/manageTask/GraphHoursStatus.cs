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
    public partial class GraphHoursStatus : Telerik.WinControls.UI.RadForm
    {
        public GraphHoursStatus()
        {
            InitializeComponent();
        }

        private void GraphHoursStatus_Load(object sender, EventArgs e)
        {
            Dictionary<string, decimal> workersDictionary = new Dictionary<string, decimal>();

            List<SumHoursDoneUser> sumHoursDoneUsers = UserLogic.getSumHoursDoneForUsers();
            if (sumHoursDoneUsers != null)
            {

                foreach (SumHoursDoneUser sumHoursDoneUser in sumHoursDoneUsers)
                {

                    workersDictionary.Add(sumHoursDoneUser.Label, sumHoursDoneUser.Data);
                }
                chart1.Series[0].Points.DataBindXY(workersDictionary.Keys, workersDictionary.Values);
            }

        }
    }
}
