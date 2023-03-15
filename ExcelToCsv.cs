using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string excelFilePath = @"C:\path\to\excel.xlsx";
        string csvFilePath = @"C:\path\to\output.csv";

        // Create connection string for Excel file
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFilePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES;'";

        // Open connection to Excel file and retrieve data
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$]", connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Write data to CSV file
            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    writer.WriteLine(string.Join(",", row.ItemArray));
                }
            }
        }

        Console.WriteLine("Excel file converted to CSV.");
        Console.ReadKey();
    }
}
