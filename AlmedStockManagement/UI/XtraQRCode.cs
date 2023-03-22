using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace AlmedStockManagement
{
    public partial class XtraQRCode : DevExpress.XtraReports.UI.XtraReport
    {
        private const string SEPARATOR = "$";

        public XtraQRCode(string code, string Lot, string DLC)
        {
            InitializeComponent();
            xrCode.Text = "Code : " + code;
            xrLot.Text = "Lot :" + Lot;
            xrDate.Text = "DLC : " + DLC;
            xrBarCode.Text = code + SEPARATOR + Lot + SEPARATOR + DLC;
        }

    }
}
