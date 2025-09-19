using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Vozilo 
    {
        public string RegBroj { get; set; }  // regBroj je primarni ključ
        public int ModelVozilaId { get; set; }
        public ModelVozila ModelVozila { get; set; }

        public int GodinaProizvodnje { get; set; }
        public int KlijentId { get; set; }
        public Klijent Klijent { get; set; }


        public override string ToString()
        {
            return RegBroj;
        }


    }
}
