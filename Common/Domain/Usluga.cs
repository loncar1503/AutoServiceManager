using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Usluga
    {
        public int Id { get; set; }  // idUsluga
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }

        public List<StavkaServisa> StavkeServisa { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
