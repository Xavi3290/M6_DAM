// Author: Tigran Gasparian
// This sample is part Part One of the 'Getting Started with SQLite in C#' tutorial at http://www.blog.tigrangasparian.com/

using System;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SQLiteSamples
{
    class Program
    {
        // Holds our connection with the database
        SQLiteConnection m_dbConnection;
        SqlConnection m_dbConnection2;
        String filename = @"c:\x\Canada.sqlite";

        static void Main(string[] args)
        {
            Program p = new Program();
        }

        public Program()
        {
            createNewDatabase();
            connectToDatabase();
            connectToDatabase2();
            createTable();
            fillTable();
           // printEmployee();
            
        }

        // Creates an empty database file
        void createNewDatabase()
        {
            SQLiteConnection.CreateFile("filename");
        }

        // Creates a connection with our database file.
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
            m_dbConnection.Open();
        }

        void connectToDatabase2()
        {
            m_dbConnection2 = new SqlConnection("Server=.;Database=Chinook;Trusted_Connection=True;");
            m_dbConnection2.Open();
        }


        // Creates a table named 'highscores' with two columns: name (a string of max 20 characters) and score (an int)
        void createTable()
        {
            string sql = "create table canada (FirstName varchar(20), LastName varchar(20))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        // Inserts some values in the highscores table.
        // As you can see, there is quite some duplicate code here, we'll solve this in part two.

        void fillTable()
        {
            string sql = "select FirstName, LastName from dbo.Customer where Country = 'Canada'";
            SqlCommand command = new SqlCommand(sql, m_dbConnection2); 
            string sqlInto = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sqlInto = "insert into canada (FirstName, LastName) values ('" + reader["FirstName"] + "','" + reader["LastName"] + "')";
                SQLiteCommand commando = new SQLiteCommand(sqlInto, m_dbConnection);
                commando.ExecuteNonQuery();
            }
        }



        // Writes the highscores to the console sorted on score in descending order.
        void printEmployee()
        {
            string sql = "select * from Employee";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("FirstName: " + reader["FirstName"] + "\tLastName: " + reader["LastName"]);
            Console.ReadLine();
        }

      
    }
}