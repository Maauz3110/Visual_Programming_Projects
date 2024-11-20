using System;
using System.Data.OleDb;

class Program
{
    static void Main()
    {
        // Replace 'C:\\Users\\Online Computer\\Downloads\\Northwind.mdb' with your actual database file path
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Online Computer\\Downloads\\Northwind.mdb";
        string queryString = "SELECT ProductID, UnitPrice, ProductName FROM Products WHERE UnitPrice > @pricePoint ORDER BY UnitPrice DESC;";
        int paramValue = 5;

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            OleDbCommand command = new OleDbCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);

            try
            {
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}