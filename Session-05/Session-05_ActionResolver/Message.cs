using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_ActionResolver
{
    public class Message
    {
        public Guid MessageID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserMessage { get; set; }
        public Message(Guid id, DateTime timeStamp, string message)
        {
            MessageID = id;
            TimeStamp = timeStamp;
            UserMessage = message;
        }
    }
}