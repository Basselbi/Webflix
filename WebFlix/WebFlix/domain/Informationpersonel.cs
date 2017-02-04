using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.Domain {
    
    public class Informationpersonel {
        public Informationpersonel() {
			Realisateur = new List<Realisateur>();
			Acteur = new List<Acteur>();
			Scenariste = new List<Scenariste>();
        }
        public virtual decimal Personelid { get; set; }
        [Length(50)]
        public virtual string Nom { get; set; }
        [Length(50)]
        public virtual string Prenom { get; set; }
        public virtual DateTime? Datenaissance { get; set; }
        [Length(75)]
        public virtual string Lieunaissance { get; set; }
        [Length(4000)]
        public virtual string Biographie { get; set; }
        public virtual IList<Realisateur> Realisateur { get; set; }
        public virtual IList<Acteur> Acteur { get; set; }
        public virtual IList<Scenariste> Scenariste { get; set; }
    }
}
