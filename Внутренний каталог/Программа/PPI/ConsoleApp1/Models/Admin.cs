using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    /// <summary>
    ///  Модель администратора
    /// </summary>
    public class Admin : IUser
    {
        /// <summary>
        ///  Идентификационный номер
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        ///  Имя
        /// </summary>
        public string FirstName { get; set; }
		
		/// <summary>
        ///  Фамилия
        /// </summary>
        public string LastName { get; set; }


		/// <summary>
        ///  Отчество
        /// </summary>
        public string MiddleName { get; set; }


        /// <summary>
        ///  Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        ///  Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///  Электронная почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///  Права
        /// </summary>
        public List<UserRightsEnum> Rights { get; set; }
    }
}
