using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_ActionResolver
{
    public class MessageLogger
    {
        public Message[] Messages { get; set; }
        
        public Message[] ReadAll()
        {
            return Messages;
        }
        public void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
        }
        public void Write()
        {
            
        }
    }
}