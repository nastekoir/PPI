using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Bl.Interfaces
{
    public interface IIdentityService
    {
        bool ResgisterNewUser(IUser user);
        bool CheckIsUserExist(Guid userID);
        bool AuthorizeUser(string userName, string password);
    }
}
