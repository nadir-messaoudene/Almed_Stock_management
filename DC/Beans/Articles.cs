using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DC
{
    [DataContract()]
    public class Articles
    {

        public Articles()
        {

        }

        [DataMember]
        public string ARTCODE { get; set; }
        [DataMember]
        public string LOTNUMBER { get; set; }
        [DataMember]
        public string DLC { get; set; }
        [DataMember]
        public int QTY { get; set; }
    }
}
