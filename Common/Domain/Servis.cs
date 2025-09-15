using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Servis : IEntity
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

        public string NazivTabele => "Servisi";

        public string Vrednosti => $"'{OpisProblema}', '{DatumPrijema.ToString("yyyy-MM-dd")}', {UkupnaCena.ToString()}, {MajstorId}, '{VoziloRegBroj}'";

        public string Kolone => "(OpisProblema, DatumPrijema, UkupnaCena, MajstorId, VoziloRegBroj)";

        public string Output => "Id";
    }
}
