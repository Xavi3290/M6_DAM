using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

/* SqlServer, Linq amb variable context (DataContext) */

namespace Exercici1Entities
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
            List<Employee> Empleats = context.Employees.ToList();
            List<Customer> Clients = context.Customers.ToList();

            /* Comprovació que la taula s'ha llegit a la classe */
            Console.WriteLine("Mostri els empleats (codi i nom) que són agents comercials (tenen clients al seu càrrec): ");
            Console.WriteLine("=============================================================== ");
            var consultaEmpleats = Empleats.Where(a => a.Customers.Count > 0);
            foreach (var empleat in consultaEmpleats)
                Console.WriteLine("Codi: " + empleat.EmployeeId + "\n" + "Nom: " + empleat.FirstName + "\n");

            Console.WriteLine("Exercici2:");
            Console.WriteLine("Quin usuari vols seleccionar? (Posa el codi)");
            Console.WriteLine("=============================================================== ");
            int codi;
            try
            {
                codi = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {Console.WriteLine("Has de posar un codi"); return; }

            Console.WriteLine("Exercici3:");
            Console.WriteLine("Mostri els clients (nom, cognom i ciutat) de l’empleat seleccionat, ordenats per ciutat, cognom i nom");
            Console.WriteLine("=============================================================== ");
            var consultaClients = Empleats.Where(a=>a.EmployeeId == codi).SelectMany(a=>a.Customers).OrderBy(a=>a.City).ThenBy(a=>a.LastName).ThenBy(a=>a.FirstName);
            foreach (var empleat in consultaClients)
                Console.WriteLine("Ciutat: " +  empleat.City + "\n" + "Cognom: " +  empleat.LastName + "\n" + "Nom: " +  empleat.FirstName + "\n");

            Console.WriteLine("-------------------------------------- Enter per a acabar... ");
            Console.ReadLine();

           

        }
    }
}