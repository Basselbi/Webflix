using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Cartecredit
    {
        public virtual decimal Carteid { get; set; }
        public virtual Users Users { get; set; }
        public virtual decimal Typecarte { get; set; }
        public virtual string Numero { get; set; }
        public virtual decimal Mois { get; set; }
        public virtual decimal Annee { get; set; }
        public virtual decimal Ccv { get; set; }
    }
}
