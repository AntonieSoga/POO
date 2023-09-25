using System;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

public class DataTableToPdf
{
    public void Export(DataTable dataTable, string pdfPath)
    {
        if (dataTable == null)
            throw new ArgumentNullException("dataTable");

        Document document = new Document();
        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

        document.Open();

        PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
        pdfTable.DefaultCell.Padding = 3;
        pdfTable.WidthPercentage = 100;
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
        pdfTable.DefaultCell.BorderWidth = 1;

        // Adding Header row
        foreach (DataColumn column in dataTable.Columns)
        {
            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTable.AddCell(cell);
        }

        // Adding DataRow
        foreach (DataRow row in dataTable.Rows)
        {
            foreach (object cell in row.ItemArray)
            {
                pdfTable.AddCell(cell.ToString());
            }
        }

        document.Add(pdfTable);
        document.Close();
        writer.Close();
    }
}
