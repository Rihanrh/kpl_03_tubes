using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PrintStruk
{
    public class PrintStrukPDF
    {
        public void GenerateReceipt(string filePath, Receipt receipt)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Add a page to the document
            PdfPage page = document.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);

            // the content on the page
            XFont titleFont = new XFont("Arial", 18, XFontStyle.Bold);
            XFont itemFont = new XFont("Arial", 12, XFontStyle.Regular);

            // title
            graphics.DrawString("Receipt", titleFont, XBrushes.Black, new XRect(0, 0, page.Width, 30), XStringFormats.Center);

            // receipt details
            graphics.DrawString($"ID Transaksi: {receipt.idTransaksi}", itemFont, XBrushes.Black, new XRect(50, 50, page.Width - 100, 20), XStringFormats.TopLeft);
            graphics.DrawString($"Tanggal: {receipt.tanggal.ToShortDateString()}", itemFont, XBrushes.Black, new XRect(50, 70, page.Width - 100, 20), XStringFormats.TopLeft);

            // item details
            int itemStartY = 100;
            foreach (var item in receipt.items)
            {
                string itemText = $"{item.nameMenu} - {item.hargaMenu:C}";
                graphics.DrawString(itemText, itemFont, XBrushes.Black, new XRect(50, itemStartY, page.Width - 100, 20), XStringFormats.TopLeft);
                itemStartY += 20;
            }

            // total cost
            graphics.DrawString($"Total Cost: {receipt.totalCost:C}", itemFont, XBrushes.Black, new XRect(50, itemStartY, page.Width - 100, 20), XStringFormats.TopLeft);

            // Save the document
            document.Save(filePath);
        }
    }
}
