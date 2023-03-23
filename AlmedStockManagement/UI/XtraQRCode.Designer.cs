namespace AlmedStockManagement
{
    partial class XtraQRCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCode,
            this.xrDate,
            this.xrLot,
            this.xrBarCode});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 234.0208F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCode
            // 
            this.xrCode.Dpi = 254F;
            this.xrCode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrCode.LocationFloat = new DevExpress.Utils.PointFloat(216.1041F, 21.16667F);
            this.xrCode.Name = "xrCode";
            this.xrCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 254F);
            this.xrCode.SizeF = new System.Drawing.SizeF(319.8959F, 58.42001F);
            this.xrCode.StylePriority.UseFont = false;
            this.xrCode.Text = "Code : ";
            // 
            // xrDate
            // 
            this.xrDate.Dpi = 254F;
            this.xrDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrDate.LocationFloat = new DevExpress.Utils.PointFloat(216.1041F, 161.1842F);
            this.xrDate.Name = "xrDate";
            this.xrDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 254F);
            this.xrDate.SizeF = new System.Drawing.SizeF(319.8959F, 58.42001F);
            this.xrDate.StylePriority.UseFont = false;
            this.xrDate.Text = "DLC : ";
            // 
            // xrLot
            // 
            this.xrLot.Dpi = 254F;
            this.xrLot.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLot.LocationFloat = new DevExpress.Utils.PointFloat(216.1041F, 92.81588F);
            this.xrLot.Name = "xrLot";
            this.xrLot.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 254F);
            this.xrLot.SizeF = new System.Drawing.SizeF(319.8959F, 58.42F);
            this.xrLot.StylePriority.UseFont = false;
            this.xrLot.Text = "LOT : ";
            // 
            // xrBarCode
            // 
            this.xrBarCode.AutoModule = true;
            this.xrBarCode.Dpi = 254F;
            this.xrBarCode.LocationFloat = new DevExpress.Utils.PointFloat(13.22917F, 25.00005F);
            this.xrBarCode.Module = 5.08F;
            this.xrBarCode.Name = "xrBarCode";
            this.xrBarCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254F);
            this.xrBarCode.ShowText = false;
            this.xrBarCode.SizeF = new System.Drawing.SizeF(184.3541F, 194.6042F);
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBarCode.Symbology = qrCodeGenerator1;
            this.xrBarCode.Text = "123456790";
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 9.395825F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XtraQRCode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.Margins = new System.Drawing.Printing.Margins(0, 8, 0, 9);
            this.PageHeight = 300;
            this.PageWidth = 550;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

#endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrDate;
        private DevExpress.XtraReports.UI.XRLabel xrLot;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode;
        private DevExpress.XtraReports.UI.XRLabel xrCode;
    }
}
