using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.Domain {
    
    public class Acteur {
        public Acteur() {
			Role = new List<Role>();
        }
        public virtual int Acteurid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        [Length(100)]
        public virtual string Nomacteur { get; set; }
        public virtual IList<Role> Role { get; set; }
    }
}
