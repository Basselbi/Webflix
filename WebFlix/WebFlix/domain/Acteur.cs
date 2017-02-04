using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.domain {
    
    public class Acteur {
        public Acteur() {
			Role = new List<Role>();
        }
        public virtual decimal Acteurid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        [Length(100)]
        public virtual string Nomacteur { get; set; }
        public virtual IList<Role> Role { get; set; }
    }
}
