namespace DC
{
    public class Items
    {
        public string Id{ get; set; }
        public string Gamme { get; set; }
        public string SuplayName { get; set; }
        public string LN { get; set; }
        public string NLot { get; set; }
        public string Qte { get; set; }
        public string BRN { get; set; }
        public string DLC { get; set; }
        public string DateCreated { get; set; }
        public string Movement { get; set; }
        public string IdReception { get; set; }
        public object IdItem { get; set; }

        public Items()
        {

        }
        public Items(string Gamme,string DLC,string LN,string NLot,string Qte)
        {
                this.Gamme = Gamme;
                this.LN = LN;
                this.Qte = Qte;
                this.SuplayName = DLC;
                this.NLot = NLot;
        }

        public override string ToString()
        {
            return this.Gamme + " : DLC(" + this.SuplayName + ").LN(" + this.LN + ").NLot(" + this.NLot +")";
        }
    }
}
