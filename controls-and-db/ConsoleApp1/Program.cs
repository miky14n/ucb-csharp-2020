using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb; // ADO.NET - OLE DB 
using System.Data.SqlClient; // ADO.NET - SQL Server only
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucb.Enrique;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Unused
            //Class2 greeting = new Class2();
            //var g = greeting.Hello();
            //Console.WriteLine(g);
            //Console.ReadKey();
            #endregion

            #region SqlServer Game
            //string connectionString =
            //"Data Source=ENRIQUE2ECD;Initial Catalog=TicTacToe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //// Provide the query string with a parameter placeholder.
            ////string queryString =
            ////"SELECT ProductID, UnitPrice, ProductName from dbo.products "
            ////    + "WHERE UnitPrice > @pricePoint "
            ////    + "ORDER BY UnitPrice DESC;";
            //string queryString =
            //    "SELECT Name, NextGamer, Game from dbo.games ";
            ////+ "WHERE Name='Enrique' "
            ////+ "ORDER BY UnitPrice DESC;";

            //// Specify the parameter value.
            //// int paramValue = 5;

            //// Create and open the connection in a using block. This
            //// ensures that all resources will be closed and disposed
            //// when the code exits.

            ////SqlConnection connection = new SqlConnection(connectionString)
            //using (SqlConnection connection =
            //    new SqlConnection(connectionString))
            //{
            //    // Create the Command and Parameter objects.
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    //command.Parameters.AddWithValue("@pricePoint", paramValue);

            //    // Open the connection in a try/catch block.
            //    // Create and execute the DataReader, writing the result
            //    // set to the console window.
            //    try
            //    {
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine("\t{0}\t{1}\t{2}",
            //                reader[0], reader[1], reader[2]);
            //        }
            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadLine();
            //}
            #endregion

            #region OleDB
            //string connectionString =
            //@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Utilities\Vuelos.mdb";

            //// Provide the query string with a parameter placeholder.
            //string queryString =
            //    "SELECT Id, Code, Description from airport ";
            //        // + "WHERE UnitPrice > @pricePoint "
            //        // + "ORDER BY UnitPrice DESC;";

            //// Specify the parameter value.
            //// int paramValue = 5;

            //// Create and open the connection in a using block. This
            //// ensures that all resources will be closed and disposed
            //// when the code exits.
            //using (OleDbConnection connection =
            //    new OleDbConnection(connectionString))
            //{
            //    // Create the Command and Parameter objects.
            //    OleDbCommand command = new OleDbCommand(queryString, connection);
            //    //command.Parameters.AddWithValue("@pricePoint", paramValue);

            //    // Open the connection in a try/catch block.
            //    // Create and execute the DataReader, writing the result
            //    // set to the console window.
            //    try
            //    {
            //        connection.Open();
            //        OleDbDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine("\t{0}\t{1}\t{2}",
            //                reader[0], reader[1], reader[2]);
            //        }
            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadLine();
            //}
            #endregion

            string connectionString =
            "Data Source=ENRIQUE2ECD;Initial Catalog=TicTacToe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // define INSERT query with parameters
            string query = "INSERT INTO dbo.games (Name, NextGamer, Game) " +
                           "VALUES (@Name, @NextGamer, @Game) ";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = "DemoEnrique";
                cmd.Parameters.Add("@NextGamer", SqlDbType.VarChar, 50).Value = "X";
                cmd.Parameters.Add("@Game", SqlDbType.VarChar, 50).Value = "::::X:O:O";

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
