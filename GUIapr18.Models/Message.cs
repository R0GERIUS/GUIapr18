using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIapr18.Models
{
    public class Message
    {
        public string Text { get; }
        public DateTime Date { get; }
        public string Sender { get; }

        public Message(string text, DateTime date, string sender)
        {
            Text = text;
            Date = date;
            Sender = sender;
        }
    }
}
