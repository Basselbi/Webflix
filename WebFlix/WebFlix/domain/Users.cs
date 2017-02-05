using System;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.Domain {
    
    public class Users {
        public Users() {
			Location = new List<Location>();
			Cartecredit = new List<Cartecredit>();
        }
        public virtual int Userid { get; set; }
        [NotNullNotEmpty]
        [Length(24)]
        public virtual string Nom { get; set; }
        [NotNullNotEmpty]
        [Length(24)]
        public virtual string Prenom { get; set; }
        [Length(60)]
        public virtual string Courriel { get; set; }
        [NotNullNotEmpty]
        [Length(12)]
        public virtual string Notelephone { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Datenaissance { get; set; }
        [NotNullNotEmpty]
        [Length(21)]
        public virtual string Motpasse { get; set; }
        public virtual IList<Location> Location { get; set; }
        public virtual IList<Cartecredit> Cartecredit { get; set; }
    }
}
