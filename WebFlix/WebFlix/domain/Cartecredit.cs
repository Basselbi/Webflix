using NHibernate.Validator;

namespace WebFlix.Domain {
    public class Cartecredit {
        public virtual int Carteid { get; set; }
        public virtual Users Users { get; set; }
        [NotNullNotEmpty]
        public virtual int Typecarte { get; set; }
        [NotNullNotEmpty]
        [Length(16)]
        public virtual string Numero { get; set; }
        [NotNullNotEmpty]
        public virtual int Mois { get; set; }
        [NotNullNotEmpty]
        public virtual int Annee { get; set; }
        [NotNullNotEmpty]
        public virtual int Ccv { get; set; }
    }
}
