using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    public class Visitor : IUser
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Login { get;set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<UserRightsEnum> Rights { get; set; }
    }
}
