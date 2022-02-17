using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    /// <summary>
    ///  Модель сообщения
    /// </summary>
    public class Message
    {
        /// <summary>
        ///  Идентификационный номер
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  Текст сообщения
        /// </summary>
        public string MessageText { get; set; }

        /// <summary>
        ///  Идентификационный номер пользователя, который отправил сообщение
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        ///  Дата создания сообщения
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        ///  Идентификационный номер ветки в которую отправлено сообщение
        /// </summary>
        public Guid BranchId { get; set; }
    }
}
