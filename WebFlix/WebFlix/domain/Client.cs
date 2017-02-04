using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator;

namespace WebFlix.Domain {
    public class Client {
        public virtual decimal Userid { get; set; }
        public virtual Forfait Forfait { get; set; }
    }
}
