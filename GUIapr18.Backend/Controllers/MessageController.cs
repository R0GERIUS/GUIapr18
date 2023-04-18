using GUIapr18.Backend.Services;
using GUIapr18.Logic;
using GUIapr18.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace GUIapr18.Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageLogic logic;
        IHubContext<SignalRHub> hub;

        public MessageController(IMessageLogic logic,  IHubContext<SignalRHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        [HttpPost]
        public void Send([FromBody] Message value)
        {
            logic.Send(value);
            hub.Clients.All.SendAsync("MessageSent", value);
        }

        [HttpGet]
        public IEnumerable<Message> GetAll()
        {
            return logic.GetMessages();
        }
    }
}
