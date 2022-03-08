using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_ActionResolver
{
    public enum ActionEnum
    {
        Covert,
        Uppercase,
        Reverse
    }
    public class ActionRequest
    {
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }
        public ActionRequest(Guid requestId, string input, ActionEnum action)
        {
            RequestID = requestId;
            Input = input;
            Action = action;
        }
    }
}