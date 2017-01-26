using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Film
    {
        public Film() { }
        public virtual decimal Filmid { get; set; }
        public virtual Realisateur Realisateur { get; set; }
        public virtual string Titre { get; set; }
        public virtual short? Annesortie { get; set; }
        public virtual string Langue { get; set; }
        public virtual short? Duree { get; set; }
        public virtual string Resume { get; set; }
        public virtual decimal? Qtytotal { get; set; }
        public virtual decimal? Qtydisponible { get; set; }
    }
}
