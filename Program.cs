using System;
using System.Collections.Generic;

namespace Github_harjoittelua
{
    class Program
    {
        static void Main(string[] args)
        {
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
