using ConsoleApp1.Bl.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Bl.Services;
public class MessageService : IMessageService
{
    public void DeleteMessage(Guid messageId)
    {
        //DELETE MessageTable WHERE Id=messageId
    }

    public void EditMessage(Guid messageId, string messageText)
    {
        //UPDATE MessageTeble SET MessageText=messageText WHERE Id=messageIdфыв
    }

    public void SendMessage(Guid branchId, Message message)
    {
        //INSERT MessageTable message.MessageText,message.UserId,message.CreatedDate,branchId
    }

}

