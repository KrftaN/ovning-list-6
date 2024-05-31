using System;
using System.Collections.Generic;
using System.Linq;

namespace övning_list._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn på matvaror:");
            string[] produkter = Console.ReadLine().Split();

            Console.WriteLine("Skriv in matvarornas priser:");
            int[] priser = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Skriv in din handlingslista:");
            string[] handlingslista = Console.ReadLine().Split();

            int totalKostnad = BeräknaTotalKostnad(produkter, priser, handlingslista);
            Console.WriteLine($"Priset för handlingslistan är {totalKostnad}");
        }

        static int BeräknaTotalKostnad(string[] produkter, int[] priser, string[] handlingslista)
        {
            Dictionary<string, int> produktTillPris = new Dictionary<string, int>();

            for (int i = 0; i < produkter.Length; i++)
            {
                produktTillPris[produkter[i]] = priser[i];
            }

            int totalKostnad = 0;
            foreach (string produkt in handlingslista)
            {
                totalKostnad += produktTillPris[produkt];
            }

            return totalKostnad;
        }
    }
}
