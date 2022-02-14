using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    /// <summary>
    ///  Модель гостя
    /// </summary>
    public class Guest
    {
        /// <summary>
        ///  Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Права
        /// </summary>
        public List<UserRightsEnum> Rights { get; set; }
    }
}
