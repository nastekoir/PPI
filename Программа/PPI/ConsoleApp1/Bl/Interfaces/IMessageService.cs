using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bl.Interfaces
{
    public interface IMessageService
    {
        void SendMessage(Guid branchId, Message message);
        void DeleteMessage(Guid messageId);
        void EditMessage(Guid messageId, string messageText);
    }
}
