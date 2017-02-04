using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.domain {
    
    public class Forfait {
        public Forfait() {
			Client = new List<Client>();
        }
        public virtual decimal Forfaitid { get; set; }
        [NotNullNotEmpty]
        [Length(13)]
        public virtual string Nomforfait { get; set; }
        public virtual double? Cout { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Locationmax { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Dureemax { get; set; }
        public virtual IList<Client> Client { get; set; }
    }
}
