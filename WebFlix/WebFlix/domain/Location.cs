using System;
using NHibernate.Validator;

namespace WebFlix.Domain {
    
    public class Location {
        public virtual int Locationid { get; set; }
        public virtual Film Film { get; set; }
        public virtual Users Users { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Datedebut { get; set; }
        public virtual DateTime? Dateretour { get; set; }

        public override string ToString()
        {
            return Film.ToString();
        }
    }
}
