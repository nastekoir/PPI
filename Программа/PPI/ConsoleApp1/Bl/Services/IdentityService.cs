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
            throw new NotImplementedException();
        }

        public bool CheckIsUserExist(Guid userID)
        {
            throw new NotImplementedException();
        }

        public bool ResgisterNewUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
