using BOL.HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class DepartmentUser
    {
        public DepartmentUser()
        {
            HourForDepartments = new List<HourForDepartment>();
            Users = new List<UserWithoutPassword>();
        }
        public int Id { get; set; }
        public string Department { get; set; }
        public  List<HourForDepartment> HourForDepartments { get; set; }
        public List<UserWithoutPassword> Users { get; set; }

    }
}
