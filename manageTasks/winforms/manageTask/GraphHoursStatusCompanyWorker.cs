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
    public partial class GraphHoursStatusCompanyWorker : Telerik.WinControls.UI.RadForm
    {
        public GraphHoursStatusCompanyWorker()
        {
            InitializeComponent();
        }

        private void GraphHoursStatusCompanyWorker_Load(object sender, EventArgs e)
        {
            Dictionary<string, decimal> projectsDictionary = TaskRequests.getHoursUsersProject();
            graph_status_hours_for_projects.Series[0].Points.DataBindXY(projectsDictionary.Keys, projectsDictionary.Values);
        }
    }
}
