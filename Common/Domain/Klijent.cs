using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent
    {
        public int Id { get; set; }  // idKlijent
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }

        //public List<Vozilo> Vozila { get; set; }

        public List<Vozilo> Vozila { get; set; } = new();
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }


    }
}
