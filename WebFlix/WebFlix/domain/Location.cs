using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Location
    {
        public virtual decimal Locationid { get; set; }
        public virtual Film Film { get; set; }
        public virtual Users Users { get; set; }
        public virtual DateTime Datedebut { get; set; }
        public virtual DateTime? Dateretour { get; set; }
    }
}
