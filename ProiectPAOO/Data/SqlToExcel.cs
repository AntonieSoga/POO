using Microsoft.Office.Interop.Excel;
using System;

namespace ProiectPAOO.Data
{
    public class SqlToExcel
    {
        public void ExportToExcel(System.Data.DataTable dataTable, string filePath)
        {
            // Create a new Excel application instance
            Application excel = new Application();

            // Create a new Excel workbook
            Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Create a new Excel worksheet
            Worksheet worksheet = workbook.ActiveSheet;

            // Populate the worksheet with the data from the DataTable
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                }
            }

            // Save the workbook to the specified file path
            workbook.SaveAs(filePath);

            // Clean up resources
            workbook.Close();
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            excel = null;
            workbook = null;
            worksheet = null;
            GC.Collect();
        }
    }
}
