using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent: IEntity
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


        public string NazivTabele => "Klijenti";

        public string Vrednosti => $"'{Ime}', '{Prezime}', '{BrojTelefona}'";


        public string Kolone => "(Ime, Prezime, BrojTelefona)";
        public string Output => "Id";
    }
}
