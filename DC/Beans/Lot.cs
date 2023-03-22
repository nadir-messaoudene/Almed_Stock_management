using System;

namespace DC
{
    public class Lot
    {
        public string provider;

        public Lot()
        {
        }

        public Lot(string exp_date, string lot_number, string invoice_n, string cty, string reception_date, string tarifCode, string itemNumber, string unityPrice, string unityPriceNet)
        {
            Exp_date = exp_date;
            Lot_number = lot_number;
            Invoice_n = invoice_n;
            Cty = cty;
            Reception_date = reception_date;
            TarifCode = tarifCode;
            ItemNumber = itemNumber;
            UnityPrice = unityPrice;
            UnityPriceNet = unityPriceNet;
        }

        public string Exp_date { get; set; }
        public string Lot_number {get; set; }
        public string Invoice_n { get; set; }
        public string Cty { get; set; }
        public string Reception_date { get; set; }
        public string TarifCode { get; set; }
        public string ItemNumber { get; set; }
        public string UnityPrice { get; set; }
        public string UnityPriceNet { get; set; }

        public string GetCode()
        {
            return String.Format("{0}{1}{2}{3}{4}", Lot_number, Exp_date, Invoice_n, Reception_date, Cty);
        }

    }
}