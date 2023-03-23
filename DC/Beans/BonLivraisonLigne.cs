using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
    public class BonLivraisonLigne
    {
        public string PLVDESIGNATION;
        public string PLVQTE;

        public BonLivraisonLigne()
        {

        }
        public string id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }
        public string NLot { get; set; }
        public string DatePeremption { get; set; }
        public int Qte { get; set; }
        public int QteScannee { get; set; }
    }
}
