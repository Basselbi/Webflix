using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Users
    {
        public Users() { }
        public virtual decimal Userid { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string Courriel { get; set; }
        public virtual string Notelephone { get; set; }
        public virtual DateTime Datenaissance { get; set; }
        public virtual string Motpasse { get; set; }
    }
}
