using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA20231024
{
    class Program
    {
        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();
            var sr = new StreamReader(@"../../src/solsys.txt");
            while (!sr.EndOfStream)
            {
                bolygok.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine("3. feladat:");

            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerben");

            var holdatlag = bolygok.Average(p => p.holdakszama);

            Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan {holdatlag:0.00} holdja van");

            var legnagyobb = bolygok.OrderBy(p => p.bolygoterfogata).Last();

            Console.WriteLine($"3.3: A legnagyobb térfogatú bolygó a {legnagyobb.nev}");

            Console.Write($"3.4 írd be a keresett bolygó nevét: ");
            string ans = Console.ReadLine();

            var find = bolygok.SingleOrDefault(b => b.nev == ans);
            Console.WriteLine(find != null ? "Van ilyen bolygó a naprendszerben! " : "Sajnos nincs ilyen nevű bolygó a naprendszerben.");

            Console.Write("3.5 Írj be egy egész számot: ");
            int ans2 = int.Parse(Console.ReadLine());

            var holdkeres = bolygok.Where(b => b.holdakszama > ans2);
            Console.WriteLine($"A következő bolygóknak van {ans2}-nál/nél több holdja: ");
            foreach (var item in holdkeres)
            {
                Console.Write($"{item.nev}, ");
            }
            Console.ReadLine();
        }
    }
}
