using NHibernate.Validator;

namespace WebFlix.Domain {
    
    public class Role {
        public virtual int Roleid { get; set; }
        public virtual Film Film { get; set; }
        public virtual Acteur Acteur { get; set; }
        [Length(100)]
        public virtual string Nompersonnage { get; set; }
    }
}
