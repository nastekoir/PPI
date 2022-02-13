using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bl.Interfaces
{
    internal interface IAdminService
    {
        bool DeleteUser(Guid userId);
        bool AppointModerator(Guid userId);
        void SetRights(Guid userId, UserRightsEnum[] rights);
    }
}
