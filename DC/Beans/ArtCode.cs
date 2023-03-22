using System.Runtime.Serialization;

namespace DC
{
    [DataContract]
    public class ArtCode
    {
        public ArtCode()
        {

        }
        [DataMember]
        public string artCode { get; set; }
    }
}
