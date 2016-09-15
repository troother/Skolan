using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering_grunder_Calle
{
    class Meddelande
    {
        public string Text { get; set; }


        public string VisaMeddelande()
        {
            return "Hello world!! " + Text;
        }

    }
}
