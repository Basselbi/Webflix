using System.Collections.Generic;
using NHibernate.Validator;
using NHibernate.Validator.Constraints;
namespace WebFlix.Domain {
    
    public class Scenariste {
        public Scenariste() {
			Scenaristefilm = new List<Scenaristefilm>();
        }
        public virtual int Scenaristeid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        [Length(100)]
        public virtual string Nomscenariste { get; set; }
        public virtual IList<Scenaristefilm> Scenaristefilm { get; set; }
    }
}
