using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bl.Interfaces
{
    /// <summary>
    ///  Интерфейс сервиса для работы с сообщениями
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        ///  Функция отправки сообщения в ветку
        /// </summary>
        void SendMessage(Guid branchId, Message message);

        /// <summary>
        ///  Функция удаления сообщения по Id
        /// </summary>
        void DeleteMessage(Guid messageId);

        /// <summary>
        ///  Функция редактирования сообщения
        /// </summary>
        void EditMessage(Guid messageId, string messageText);
		
		void SetRating(bool rating)
    }
}
