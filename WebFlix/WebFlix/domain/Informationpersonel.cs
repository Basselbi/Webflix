using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Informationpersonel
    {
        public Informationpersonel() { }
        public virtual decimal Personelid { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual DateTime? Datenaissance { get; set; }
        public virtual string Lieunaissance { get; set; }
        public virtual string Biographie { get; set; }
    }
}
