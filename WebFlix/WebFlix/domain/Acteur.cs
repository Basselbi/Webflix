using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Acteur
    {
        public Acteur() { }
        public virtual decimal Acteurid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        public virtual string Nomacteur { get; set; }
    }
}
