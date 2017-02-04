using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.Domain {
    public class Cartecredit {
        public virtual decimal Carteid { get; set; }
        public virtual Users Users { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Typecarte { get; set; }
        [NotNullNotEmpty]
        [Length(16)]
        public virtual string Numero { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Mois { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Annee { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Ccv { get; set; }
    }
}
