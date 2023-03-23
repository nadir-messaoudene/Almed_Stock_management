using System.Runtime.Serialization;

namespace DC
{
    public class PieceDiversLigne
    {
        public PieceDiversLigne()
        {
               
        }
        public string ARTID { get; set; }
        public string PLDDESIGNATION { get; set; }
        public string PLDID { get; set; }
        public string PLDNUMLOT { get; set; }
        public int Qte { get; set; }

        public string LN { get; set; }
        public string PLDFEFOPEREMPTION { get; set; }

    }
}
