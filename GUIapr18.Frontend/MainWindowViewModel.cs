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

        public ICommand SendMessageCommand { get; set; }

        public MainWindowViewModel() 
        {
            Messages = new RestCollection<Message>("http://localhost:5258/", "message");
        }
    }
}
