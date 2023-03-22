using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
    [DataContract()]
    public class Article_P
    {
        public Article_P()
        {

        }
        [DataMember()]
        public string Code { get; set; }
    }
}
