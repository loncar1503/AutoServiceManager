using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Vozilo : IEntity
    {
        public string RegBroj { get; set; }  // regBroj je primarni ključ
        public int ModelVozilaId { get; set; }
        public ModelVozila ModelVozila { get; set; }

        public int GodinaProizvodnje { get; set; }
        public int KlijentId { get; set; }
        public Klijent Klijent { get; set; }

        public string NazivTabele => "Vozila";

        public string Vrednosti => $"'{RegBroj}', {KlijentId}, {GodinaProizvodnje}, {ModelVozilaId}";


        public string Kolone => "(RegBroj, KlijentId, GodinaProizvodnje, ModelVozilaId)";

        //public string Uslov => throw new NotImplementedException();

        //public string UslovBezAlijasa => throw new NotImplementedException();

        public string Output => "";

        //public string Kriterijum => throw new NotImplementedException();

        //public string JoinUslov => throw new NotImplementedException();

        //public string UpdateUslov => throw new NotImplementedException();

        public override string ToString()
        {
            return RegBroj;
        }


    }
}
