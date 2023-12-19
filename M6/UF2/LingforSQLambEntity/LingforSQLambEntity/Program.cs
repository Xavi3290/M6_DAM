//using LingforSQLambEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

/* SqlServer, Linq amb variable context (DataContext) */

namespace LingforSQLambEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
        }

        

        public Program()
        {

            // var context = new DataContext(connection);
            ChinookEntities context = new ChinookEntities();

            // var Artists = context.GetTable<Artista>();
            List<Artist> Artists = context.Artists.ToList();

            /* Comprovació que la taula s'ha llegit a la classe */
            Console.WriteLine("Llista (desordenada) de tots els artistes de la taula mapejada: ");
            Console.WriteLine("=============================================================== ");
            foreach (var artista in Artists)
                Console.WriteLine(artista.Name);

            Console.WriteLine("---------------------------------------------- Enter per a continuar... ");
            Console.ReadLine();

            /* Selecció amb LINQ d'un subconjunt de dades de la classe mapejada */
            Console.WriteLine("\n\n");
            Console.WriteLine("Llista ordenada d'artistes de la taula mapejada que comencen per A (obtinguts amb LINQ): ");
            Console.WriteLine("======================================================================================== ");
            List<Artist> artistes = (from a in Artists
                           where a.Name.StartsWith("A")
                           orderby a.Name
                           select a).OrderByDescending(a=>a.Name).ToList();
            foreach (var artista in artistes)
                Console.WriteLine(artista.Name);

            Console.WriteLine("-------------------------------------- Enter per a acabar... ");
            Console.ReadLine();
        }
    }
}