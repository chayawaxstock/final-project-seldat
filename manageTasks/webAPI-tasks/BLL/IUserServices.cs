using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IUserServices
    {
        int Authenticate(string userName, string password);
    }
}
