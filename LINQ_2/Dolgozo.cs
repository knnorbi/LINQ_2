using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2
{
    class Dolgozo
    {
        public string Nev { get; private set; }
        public bool Ferfi { get; private set; }
        public string Reszleg { get; private set; }
        public int BelepesEve { get; private set; }
        public int Ber { get; private set; }

        public Dolgozo(string sor)
        {
            string[] adatok = sor.Split(';');

            Nev = adatok[0];
            Ferfi = adatok[1] == "férfi";
            Reszleg = adatok[2];
            BelepesEve = int.Parse(adatok[3]);
            Ber = int.Parse(adatok[4]);
        }

        public override string ToString()
        {
            return $"{Nev} ({Reszleg})";
        }

        public static Dolgozo[] Betolt(string path)
        {
            return File.ReadAllLines(path).Skip(1).Select(d => new Dolgozo(d)).ToArray();
        }
    }
}
