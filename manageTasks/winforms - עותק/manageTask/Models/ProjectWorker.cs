using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Models
{
   public class ProjectWorker
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public decimal HoursForProject { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
        public decimal SumHoursDone { get; set; }
    }
}
