using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

/* SqlServer, Linq amb variable context (DataContext) */

namespace Chinook
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
        }

        [Table(Name = "Artist")]
        public class Artista
        {
            [Column(IsPrimaryKey = true, Name ="ArtistId")]
            public int codi { get; set; }
            [Column(Name ="Name")]
            public string nom { get; set; }
        }

        public Program()
        {
            var connection = new SqlConnection(@"Data Source=.;Initial Catalog=Chinook;Trusted_Connection=true;");
            var context = new DataContext(connection);

            var Artists = context.GetTable<Artista>();

            /* Comprovació que la taula s'ha llegit a la classe */
            Console.WriteLine("Llista (desordenada) de tots els artistes de la taula mapejada: ");
            Console.WriteLine("=============================================================== ");
            foreach (var artista in Artists)
                Console.WriteLine(artista.nom);

            Console.WriteLine("---------------------------------------------- Enter per a continuar... ");
            Console.ReadLine();

            /* Selecció amb LINQ d'un subconjunt de dades de la classe mapejada */
            Console.WriteLine("\n\n");
            Console.WriteLine("Llista ordenada d'artistes de la taula mapejada que comencen per A (obtinguts amb LINQ): ");
            Console.WriteLine("======================================================================================== ");
            var artistes = from a in Artists
                           where a.nom.StartsWith("A")
                           orderby a.nom
                           select a;
            foreach (var artista in artistes)
                Console.WriteLine(artista.nom);

            Console.WriteLine("-------------------------------------- Enter per a acabar... ");
            Console.ReadLine();
        }
    }
}