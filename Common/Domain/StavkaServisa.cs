using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class StavkaServisa
    {
        public int Rb { get; set; } // Redni broj stavke
        public double Cena { get; set; }
        public string Napomena { get; set; }

        public int ServisId { get; set; }
        public Servis Servis { get; set; }

        public int UslugaId { get; set; }
        public Usluga Usluga { get; set; }


    }
}
