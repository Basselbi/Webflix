using System.Collections.Generic;
using NHibernate.Validator;
using NHibernate.Validator.Constraints;

namespace WebFlix.Domain {
    
    public class Realisateur {
        public Realisateur() {
			Film = new List<Film>();
        }
        public virtual int Realisateurid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        [Length(100)]
        public virtual string Nomrealisateur { get; set; }
        public virtual IList<Film> Film { get; set; }
    }
}
