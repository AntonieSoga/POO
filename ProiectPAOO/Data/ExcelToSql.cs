using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Linq;

namespace ProiectPAOO.Data
{
    public class ExcelToMySql
    {
        public void ImportData(string filePath, string connectionString, string tableName)
        {
            // Open the workbook and select the first worksheet
            Application excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Open(filePath);
            Worksheet worksheet = workbook.Sheets[1];

            // Get the range of cells in the worksheet
            Range range = worksheet.UsedRange;
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            // Create a DataTable to hold the data
            System.Data.DataTable dataTable = new System.Data.DataTable();
            for (int i = 1; i <= colCount; i++)
            {
                string columnName = range.Cells[1, i].Value2.ToString();
                dataTable.Columns.Add(columnName);
            }

            // Loop through the rows in the worksheet and add them to the DataTable
            for (int i = 2; i <= rowCount; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int j = 1; j <= colCount; j++)
                {
                    dataRow[j - 1] = range.Cells[i, j].Value2;
                }
                dataTable.Rows.Add(dataRow);
            }

            // Close the workbook and Excel application
            workbook.Close();
            excelApp.Quit();

            // Validate that the Excel file matches the structure of the existing table
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Get the column names and data types of the existing table
                MySqlCommand schemaCommand = new MySqlCommand($"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", connection);
                MySqlDataReader reader = schemaCommand.ExecuteReader();
                Dictionary<string, string> tableSchema = new Dictionary<string, string>();
                while (reader.Read())
                {
                    tableSchema[reader.GetString(0)] = reader.GetString(1);
                }
                reader.Close();

                // Check that the column names and data types match
                foreach (DataColumn column in dataTable.Columns)
                {
                    string columnName = column.ColumnName;
                    string columnDataType = column.DataType.ToString();

                    if (!tableSchema.ContainsKey(columnName) || tableSchema[columnName] != columnDataType)
                    {
                        Console.WriteLine($"Error: Column '{columnName}' does not match the corresponding column in the table '{tableName}'");
                        return;
                    }
                }
               
                   
                    // Truncate the destination table
                    MySqlCommand truncateCommand = new MySqlCommand($"TRUNCATE TABLE {tableName}", connection);
                    truncateCommand.ExecuteNonQuery();

                    // Create the insert command with parameter placeholders
                    string insertCommandText = $"INSERT INTO {tableName} ({string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName))}) VALUES ({string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(c => "@" + c.ColumnName))})";
                    MySqlCommand insertCommand = new MySqlCommand(insertCommandText, connection);

                    // Add parameters to the insert command
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        insertCommand.Parameters.Add("@" + column.ColumnName, MySqlDbType.VarChar);
                        insertCommand.Parameters["@" + column.ColumnName].SourceColumn = column.ColumnName;
                    }

                    // Use a MySqlDataAdapter to perform the bulk insert
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.InsertCommand = insertCommand;
                    dataAdapter.UpdateBatchSize = 1000;
                    dataAdapter.Update(dataTable);
                    
                


            }
        }
    }
}
