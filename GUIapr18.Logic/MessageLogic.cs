using GUIapr18.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIapr18.Logic
{
    public class MessageLogic : IMessageLogic
    {
        ObservableCollection<Message> Messages { get; }

        public MessageLogic() 
        {
            Messages = new ObservableCollection<Message>();
        }

        public IList<Message> GetMessages()
        {
            return Messages;
        }

        public void Send(Message message) 
        {
            Messages.Add(message);
        }
    }
}
