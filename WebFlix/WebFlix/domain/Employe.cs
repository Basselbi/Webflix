using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.Domain {
    public class Employe {
        public virtual decimal Userid { get; set; }
        [Length(24)]
        public virtual string Matricule { get; set; }
    }
}
