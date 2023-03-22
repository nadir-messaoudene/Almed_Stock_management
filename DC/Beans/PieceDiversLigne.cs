using System.Runtime.Serialization;

namespace DC
{
    [DataContract]
    public class PieceDiversLigne
    {
        public PieceDiversLigne()
        {
               
        }

        [DataMember]
        public string ARTID { get; set; }
        [DataMember]
        public string PLDDESIGNATION { get; set; }
        [DataMember]
        public string PLDID { get; set; }
        [DataMember]
        public string PLDNUMLOT { get; set; }
        [DataMember]
        public int Qte { get; set; }
    }
}
