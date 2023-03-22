using System.Runtime.Serialization;

namespace DC
{
    [DataContract()]
    public class BonLivraison
    {
        public BonLivraison()
        {

        }
        [DataMember()]
        public string id { get; set; }
        [DataMember()]
        public string NBL { get; set; }
        [DataMember()]
        public string NomClient { get; set; }
        [DataMember()]
        public string Date { get; set; }
    }
}
