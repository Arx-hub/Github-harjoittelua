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

        static void PoistaKirja(List<Kirja> kirjat)
        {
            Console.WriteLine("Anna kirjan nimi, jonka haluat poistaa listalta:");
            string haluttuKirja = Console.ReadLine();

            bool löytyi = false;

            foreach (var kirja in kirjat)
            {
                if (kirja.Nimi.Equals(haluttuKirja, StringComparison.OrdinalIgnoreCase))
                {
                    kirjat.Remove(kirja);
                    Console.WriteLine("Kirja poistettu listalta!");
                    löytyi = true;
                }
            }

            if (!löytyi)
            {
                Console.WriteLine("Ei kirjoja annetulla nimellä.");
            }
        }

        static void TulostaKirjat(List<Kirja> kirjat)
        {
            if (kirjat.Count == 0)
            {
                Console.WriteLine("Ei kirjoja listalla.");
                return;
            }

            Console.WriteLine("Kaikki kirjat:");
            foreach (var kirja in kirjat)
            {
                Console.WriteLine(kirja);
            }
        }

        static void TulostaGenrenMukaan(List<Kirja> kirjat)
        {
            Console.Write("Anna genre: ");
            string haluttuGenre = Console.ReadLine();

            bool löytyi = false;

            foreach (var kirja in kirjat)
            {
                if (kirja.Genre.Equals(haluttuGenre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(kirja);
                    löytyi = true;
                }
            }

            if (!löytyi)
            {
                Console.WriteLine("Ei kirjoja annetulla genrellä.");
            }
        }
    }

    

    class Kirja
    {
        private string nimi;
        private string kirjoittaja;
        private int julkaisuvuosi;
        private string genre;

        public string Nimi => nimi;
        public string Genre => genre;

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
