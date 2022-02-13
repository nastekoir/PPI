using ConsoleApp1.Enums;

namespace ConsoleApp1.Interfaces
{
    internal interface IUser
    {
        Guid Id { get; }    
        string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        List<UserRightsEnum> Rights { get; set; }
    }
}
