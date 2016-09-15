using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering_övn_01
{
    class Message
    {
        public string Text { get; set; }

        public string ShowMessage()
        {
            return "hello!! " + Text;
        }
    }


}
