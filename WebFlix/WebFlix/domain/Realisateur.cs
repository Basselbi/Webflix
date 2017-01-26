using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Realisateur
    {
        public Realisateur() { }
        public virtual decimal Realisateurid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        public virtual string Nomrealisateur { get; set; }
    }
}
