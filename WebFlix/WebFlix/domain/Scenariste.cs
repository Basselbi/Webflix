using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Scenariste
    {
        public Scenariste() { }
        public virtual decimal Scenaristeid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        public virtual string Nomscenariste { get; set; }
    }
}
