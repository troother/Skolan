using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_övning_5
{
    class Lektion
    {
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }


        public Lektion()
        {
            StartTid = DateTime.Now;
            SlutTid = DateTime.Now;
        }
        public bool Boka()
        {
            if (StartTid.ToString() == "" || SlutTid.ToString() == "")
                return false;
            else
            {
                return true;
            }
        }

        public void TaBort()
        {
            //todo massa grejer
        }
    }
}
