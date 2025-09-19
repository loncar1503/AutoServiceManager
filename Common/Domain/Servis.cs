using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Servis 
    {
        public int Id { get; set; }  // idServis
        public string OpisProblema { get; set; }
        public DateTime DatumPrijema { get; set; }
        public double UkupnaCena { get; set; }

        public int MajstorId { get; set; }
        public Majstor Majstor { get; set; }

        public string VoziloRegBroj { get; set; }
        public Vozilo Vozilo { get; set; }

        public List<StavkaServisa> Stavke { get; set; }


    }
}
