using System.Runtime.Serialization;

namespace DC
{
    public class BonLivraison
    {
        public BonLivraison()
        {

        }
        public string id { get; set; }
        public string NBL { get; set; }
        public string NomClient { get; set; }
        public string Date { get; set; }
    }
}
