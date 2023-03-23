using System.Runtime.Serialization;

namespace DC
{
    [DataContract]
    public class PieceVentes
    {
        public PieceVentes()
        {

        }
        public string PCDNUM { get; set; }
        public string PCVID { get; set; }
        public int QTY { get; set; }
    }
}
