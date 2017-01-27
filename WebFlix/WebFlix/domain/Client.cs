using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace WebFlix.domain {
    
    public class Client {
        public virtual decimal Userid { get; set; }
        public virtual Forfait Forfait { get; set; }
    }
}
