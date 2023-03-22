using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
    [DataContract]
    public class BonLivraisonLigne
    {
        public string PLVDESIGNATION;
        public string PLVQTE;

        public BonLivraisonLigne()
        {

        }
        public string id { get; set; }
        [DataMember()]
        public string Code { get; set; }
        [DataMember()]
        public string Designation { get; set; }
        [DataMember()]
        public string NLot { get; set; }
        [DataMember()]
        public string DatePeremption { get; set; }
        [DataMember()]
        public int Qte { get; set; }
        public int QteScannee { get; set; }
    }
}
