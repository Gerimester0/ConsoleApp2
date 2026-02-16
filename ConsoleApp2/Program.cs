using System.Text.Json;
using System.Text.Json.Serialization;

namespace Json_
{
    class Adat 
    {
        public List<string> nevek { get; set; }

        public List<int> korok { get; set; }
    }
    class Diak 
    {
        public string nev { get; set; }
        public List<int> jegyek { get; set; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            String fajl = File.ReadAllText("adatok.json",System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);

            Adat adat = JsonSerializer.Deserialize<Adat>(fajl);

            foreach (var nev in adat.nevek) 
            {
                Console.WriteLine(nev);
            }
            //első életkor
            Console.WriteLine($"{adat.nevek} életkora:{adat.korok[0]}");

            fajl = File.ReadAllText("diakok.json", System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
            List<Diak> diakok = JsonSerializer.Deserialize<List<Diak>>(fajl);
            Console.Write("Keresett név: ");
            String neve = Console.ReadLine();

            bool megvan = false;

            foreach (var diak in diakok)
            {
                if (diak.nev == neve)
                {
                    Console.WriteLine($"Átlaga: "+diak.jegyek.Average());
                    megvan = true;
                }
            }
            if (megvan == false) 
            {
                Console.WriteLine("Nincs ilyen nevű diák!");
            }
        }
    }
}
