using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlix.domain
{
    public class Genre
    {
        public Genre() { }
        public virtual decimal Genreid { get; set; }
        public virtual string Nomgenre { get; set; }
    }
}
