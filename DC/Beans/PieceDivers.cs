using System.Runtime.Serialization;

namespace DC
{
    [DataContract]
    public class PieceDivers
    {

        public PieceDivers()
        {
        }
        [DataMember]
        public string PCDID { get; set; }
        [DataMember]
        public string PCDNUM { get; set; }
        [DataMember]
        public string PCDATECREATED { get; set; }
    }
}
