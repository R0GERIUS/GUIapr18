using GUIapr18.Models;

namespace GUIapr18.Logic
{
    public interface IMessageLogic
    {
        IList<Message> GetMessages();
        void Send(Message message);
    }
}