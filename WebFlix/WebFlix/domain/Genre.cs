using System.Collections.Generic;
using NHibernate.Validator;
using NHibernate.Validator.Constraints;

namespace WebFlix.Domain {
    public class Genre {
        public Genre() {
			Filmgenre = new List<Filmgenre>();
        }
        public virtual int Genreid { get; set; }
        [NotNullNotEmpty]
        [Length(50)]
        public virtual string Nomgenre { get; set; }
        public virtual IList<Filmgenre> Filmgenre { get; set; }
    }
}
