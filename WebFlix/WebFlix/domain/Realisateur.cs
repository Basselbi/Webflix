using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace WebFlix.domain {
    
    public class Realisateur {
        public Realisateur() {
			Film = new List<Film>();
        }
        public virtual decimal Realisateurid { get; set; }
        public virtual Informationpersonel Informationpersonel { get; set; }
        [Length(100)]
        public virtual string Nomrealisateur { get; set; }
        public virtual IList<Film> Film { get; set; }
    }
}
