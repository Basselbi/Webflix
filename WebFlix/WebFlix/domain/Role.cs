using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace WebFlix.domain {
    
    public class Role {
        public virtual decimal Roleid { get; set; }
        public virtual Film Film { get; set; }
        public virtual Acteur Acteur { get; set; }
        [Length(100)]
        public virtual string Nompersonnage { get; set; }
    }
}
