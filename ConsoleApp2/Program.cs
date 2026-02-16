using System.Text.Json;
using System.Text.Json.Serialization;

namespace Json_
{
    class Adat 
    {
        public List<string> nevek { get; set; }

        public List<int> korok { get; set; }
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
        }
    }
}
