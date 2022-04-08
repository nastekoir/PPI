using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bl.Interfaces
{
    /// <summary>
    ///  Интерфейс сервиса для работы с панелью админа
    /// </summary>
    internal interface IAdminService
    {
        /// <summary>
        ///  Удаление пользователя по Id
        /// </summary>
        bool DeleteUser(Guid userId);

        /// <summary>
        ///  Назачение пользователю прав модератора
        /// </summary>
        bool AppointModerator(Guid userId);

        /// <summary>
        ///  Назначение пользователю определённых прав
        /// </summary>
        void SetRights(Guid userId, UserRightsEnum[] rights);
		
		/// <summary>
        ///  Загрушить пользователя
        /// </summary>
		void MuteUser(Guid userId)
    }
}
