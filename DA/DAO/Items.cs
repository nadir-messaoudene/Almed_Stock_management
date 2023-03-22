namespace DA
{
    public class Items
    {
        public string IdItem { get; internal set; }
        public string Gamme { get; internal set; }
        public string DLC { get; internal set; }
        public string LN { get; internal set; }
        public string NLot { get; internal set; }
        public string Qte { get; internal set; }


        public Items()
        {

        }
        public Items(string Gamme,string DLC,string LN,string NLot,string Qte)
        {

                this.Gamme = Gamme;
                this.LN = LN;
                this.Qte = Qte;
                this.DLC = DLC;
                this.NLot = NLot;
        }

        public override string ToString()
        {
            return this.Gamme + " : DLC(" + this.DLC + ").LN(" + this.LN + ").NLot(" + this.NLot +")";
        }
    }
}
