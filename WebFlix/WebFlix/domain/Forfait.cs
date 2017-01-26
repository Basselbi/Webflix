using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Forfait
    {
        public Forfait() { }
        public virtual decimal Forfaitid { get; set; }
        public virtual string Nomforfait { get; set; }
        public virtual double? Cout { get; set; }
        public virtual decimal Locationmax { get; set; }
        public virtual decimal Dureemax { get; set; }
    }
}
