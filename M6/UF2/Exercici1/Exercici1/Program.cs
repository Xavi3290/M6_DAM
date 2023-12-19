// Author: Tigran Gasparian
// This sample is part Part One of the 'Getting Started with SQLite in C#' tutorial at http://www.blog.tigrangasparian.com/

using System;
using System.Data.SQLite;

namespace SQLiteSamples
{
    class Program
    {
        // Holds our connection with the database
        SQLiteConnection m_dbConnection;
        String filename = @"c:\x\Chinook_Sqlite.sqlite";

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
            printEmployee();
            printEmployee2();
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



        // Creates a table named 'highscores' with two columns: name (a string of max 20 characters) and score (an int)
        void createTable()
        {
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        // Inserts some values in the highscores table.
        // As you can see, there is quite some duplicate code here, we'll solve this in part two.

        void fillTable()
        {
            string sql = "insert into highscores (name, score) values ('Me', 3000)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('Myself', 6000)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('And I', 9001)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
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

        void printEmployee2()
        {
            string sql = "Select Artist.Name,Album.Title  from Artist\r\nleft join Album on Album.ArtistId = Artist.ArtistId\r\nwhere Name like \"A%\"\r\norder by Artist.Name, Album.Title";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("ArtistName: " + reader["Name"] + "\tAlbumTitle: " + reader["Title"]);
            Console.ReadLine();
        }
    }
}