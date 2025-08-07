using System;
using System.Collections.Generic;

namespace Github_harjoittelua
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kirja> kirjat = new List<Kirja>();
        }

        static void LisaaKirja(List<Kirja> kirjat)
        {
            Console.Write("Anna kirjan nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Anna kirjoittajan nimi: ");
            string kirjoittaja = Console.ReadLine();

            Console.Write("Anna julkaisuvuosi: ");
            int julkaisuvuosi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Anna genre: ");
            string genre = Console.ReadLine();

            kirjat.Add(new Kirja(nimi, kirjoittaja, julkaisuvuosi, genre));
            Console.WriteLine("Kirja lisätty!");
        }
    }

    

    class Kirja
    {
        private string nimi;
        private string kirjoittaja;
        private int julkaisuvuosi;
        private string genre;

        public Kirja(string nimi, string kirjoittaja, int julkaisuvuosi, string genre)
        {
            this.nimi = nimi;
            this.kirjoittaja = kirjoittaja;
            this.julkaisuvuosi = julkaisuvuosi;
            this.genre = genre;
        }

        public override string ToString()
        {
            return $"{nimi}, {kirjoittaja}, {julkaisuvuosi}, {genre}";
        }
    }
}
