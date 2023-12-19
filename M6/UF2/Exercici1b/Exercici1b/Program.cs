// Author: Tigran Gasparian
// This sample is part Part One of the 'Getting Started with SQLite in C#' tutorial at http://www.blog.tigrangasparian.com/

using System;
using System.Data.SqlClient;

namespace SQLiteSamples
{
    class Program
    {
        // Holds our connection with the database
        SqlConnection m_dbConnection;
      //      String filename = @"c:\x\Chinook_Sqlite.sqlite";

        static void Main(string[] args)
        {
            Program p = new Program();
        }

        public Program()
        {
            //   createNewDatabase();
            connectToDatabase();
            //   createTable();
            //   fillTable();
          //  printEmployee();
            printEmployee2();
        }

       

        // Creates a connection with our database file.
        void connectToDatabase()
        {
            m_dbConnection = new SqlConnection("Server =.; Database = Chinook; Trusted_Connection = True;");
            m_dbConnection.Open();
        }



       

        void printEmployee2()
        {
            string sql = "Select Artist.Name,Album.Title  from Artist left join Album on Album.ArtistId = Artist.ArtistId where Artist.Name like 'A%' order by Artist.Name, Album.Title";
            SqlCommand command = new SqlCommand(sql, m_dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("ArtistName: " + reader["Name"] + "\tAlbumTitle: " + reader["Title"]);
            Console.ReadLine();
        }
    }
}