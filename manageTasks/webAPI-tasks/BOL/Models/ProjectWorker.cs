using BOL.HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
   public class ProjectWorker
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public decimal HoursForProject { get; set; }
        public Project Project { get; set; }
        public UserWithoutPassword User { get; set; }
        public decimal sumHoursDone { get; set; }
    }
}
