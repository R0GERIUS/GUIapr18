using CommunityToolkit.Mvvm.Input;
using GUIapr18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUIapr18.Frontend
{
    public class MainWindowViewModel
    {
        public RestCollection<Message> Messages { get; set; }

        public string Text { get; set; }
        public string Sender { get; set; }

        public ICommand SendMessageCommand { get; set; }

        public MainWindowViewModel() 
        {
            Messages = new RestCollection<Message>("http://localhost:5258/", "message", "hub")
            {
                new Message()
                {
                    Sender = "Alice",
                    Date = DateTime.Now,
                    Text = "Hi!"
                },
                new Message()
                {
                    Sender = "Bob",
                    Date = DateTime.Now,
                    Text = "Hi!"
                }
            };
            SendMessageCommand = new RelayCommand(() => 
            {
                Messages.Add(new Message()
                {
                    Sender = Sender, 
                    Date = DateTime.Now,
                    Text = Text
                });
            });
        }
    }
}
