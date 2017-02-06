using NHibernate.Validator;
using NHibernate.Validator.Constraints;
namespace WebFlix.Domain {
    public class Employe {
        public virtual int Userid { get; set; }
        [Length(24)]
        public virtual string Matricule { get; set; }
    }
}
