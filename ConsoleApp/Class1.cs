using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Proizvod
    {
        public required string Naziv;
        public decimal Cijena;
        public int DostupnaKolicina;
    }

    public Proizvod(string naziv, decimal cijena, int kolicina)
    {
        string Naziv = naziv;
        decimal Cijena = cijena;
        int DostupnaKolicina = kolicina;
    }

    public void IspisInformacije()
    {
        object? Naziv = null;
        object? Cijena = null;
        object DostupnaKolicina = 0;
        Console.WriteLine($"{1} {Naziv}, {2} {Cijena} eura, {3} {DostupnaKolicina}");
    }
}
