using ConsoleApp1.Bl.Interfaces;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class IdentityService : IIdentityService
    {
        public bool AuthorizeUser(string userName, string password)
        {
            return true;
        }

        public bool CheckIsUserExist(Guid userID)
        {
            return true;
        }

        public bool ResgisterNewUser(IUser user)
        {
            if(true)
            return true;
        }
    }
}
