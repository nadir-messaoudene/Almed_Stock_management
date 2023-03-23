using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DC
{
    public class Articles
    {

        public Articles()
        {

        }
        public string ARTCODE { get; set; }
        public string LOTNUMBER { get; set; }
        public string DLC { get; set; }
        public int QTY { get; set; }
    }
}
