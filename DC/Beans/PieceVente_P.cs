using System.Runtime.Serialization;
namespace DC
{
    [DataContract]
    public class PieceVente_P
    {
        public PieceVente_P()
        {

        }
        [DataMember]
        public string PCVID { get; set; }
        [DataMember]
        public string Livres { get; set; }
    }
}
