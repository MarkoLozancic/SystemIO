using System;
using System.IO;
namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Unesite putanju direktorija:");
            string putanja = Console.ReadLine();


            //provjera postojanja direktorija


            if(Directory.Exists(putanja))
            {
                //Ako direktorij postoji, ispisujemo sve datoteke u njemu

                Console.WriteLine("Datoteke: ");

                foreach ( string datoteka in Directory.GetFiles(putanja))
                {
                    
                    Console.WriteLine(datoteka);
                    

                }
            }


            string putanjaPoddirektorija = "\\Test";

            string novaPutanja = putanja + putanjaPoddirektorija;

            if (Directory.Exists(putanja + putanjaPoddirektorija))
            {

            }

            if (!Directory.Exists(novaPutanja)) 
            {
                Directory.CreateDirectory(novaPutanja);
            }
            else
            {
                Console.WriteLine("Direktorij vec postoji.");
                      
            }


            //ispis svih poddirektorija
            
            foreach(string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }
           
            Console.WriteLine("Ispis  svih poddirektorija zadanog direktorija: " + Directory.GetDirectories(putanja));


            //brisanje poddirektorija
            Directory.Delete(novaPutanja);
         

            //nakon brisanja
            Console.WriteLine("Nakon brisanja: ");
            foreach (string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }
            Console.ReadKey();
        }
    }
}
