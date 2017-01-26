using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Role
    {
        public virtual decimal Roleid { get; set; }
        public virtual Film Film { get; set; }
        public virtual Acteur Acteur { get; set; }
        public virtual string Nompersonnage { get; set; }
    }
}
