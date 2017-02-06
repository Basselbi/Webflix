using System.Collections.Generic;
using NHibernate.Validator;
using NHibernate.Validator.Constraints;
namespace WebFlix.Domain {
    
    public class Forfait {
        public Forfait() {
			Client = new List<Client>();
        }
        public virtual int Forfaitid { get; set; }
        [NotNullNotEmpty]
        [Length(13)]
        public virtual string Nomforfait { get; set; }
        public virtual double? Cout { get; set; }
        [NotNullNotEmpty]
        public virtual int Locationmax { get; set; }
        [NotNullNotEmpty]
        public virtual int Dureemax { get; set; }
        public virtual IList<Client> Client { get; set; }
    }
}
