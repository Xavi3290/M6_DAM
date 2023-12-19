using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiEntitiesExtra
{
    internal class Program
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
            List<Track> Cansons = context.Tracks.ToList();


            /* Comprovació que la taula s'ha llegit a la classe */
            Console.WriteLine("Mostri el nom de l’artista, el títol de l’àlbum i el nom de la cançó per a aquelles cançons que continguin una paraula introduïda per l’usuari.\r\n\r\nLes dades s’han de mostrar ordenades pels noms d’artista, àlbum i cançó: ");
            Console.WriteLine("=============================================================== \n");
            Console.WriteLine("Escriu un tros del nom de una canço");
            String cansoPre = (Console.ReadLine());

            var consultaCansons = Cansons.Where(a => a.Name.ToLower().Contains(cansoPre.ToLower())).OrderBy(a => a.Album.Artist.Name).ThenBy(a => a.Album.Title).ThenBy(a => a.Name);
            foreach (var canso in consultaCansons)
                Console.WriteLine("Nom Artista: " + canso.Album.Artist.Name + "\n" + "Album: " + canso.Album.Title + "\n" + "Canço: " + canso.Name);

            Console.WriteLine("-------------------------------------- Enter per a acabar... ");
            Console.ReadLine();



        }
    }
}
