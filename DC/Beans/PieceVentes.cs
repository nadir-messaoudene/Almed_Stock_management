using System.Runtime.Serialization;

namespace DC
{
    [DataContract]
    public class PieceVentes
    {
        public PieceVentes()
        {

        }
        [DataMember]
        public string PCDNUM { get; set; }
        [DataMember]
        public string PCVID { get; set; }
        [DataMember]
        public int QTY { get; set; }
    }
}
