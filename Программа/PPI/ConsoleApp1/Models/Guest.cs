using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    public class Guest
    {
        public string Name { get; set; }
        public List<UserRightsEnum> Rights { get; set; }
    }
}
