using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pocetniNiz = { 3, 4, 5, 7, 10, 20 };

            Console.WriteLine("Za koliko mesta menjate niz?");
            int broj = int.Parse(Console.ReadLine());

            int[] noviNiz = new int[pocetniNiz.Length + broj];

            for (int indeks = 0; indeks < noviNiz.Length; indeks++)
            {
                noviNiz[indeks] = pocetniNiz[indeks];
            }

            pocetniNiz = noviNiz;

            Console.ReadKey();
        }
    }
}
