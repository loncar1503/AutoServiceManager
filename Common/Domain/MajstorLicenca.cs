using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class MajstorLicenca: IEntity
    {
        public int MajstorId { get; set; }
        public Majstor Majstor { get; set; }

        public int LicencaId { get; set; }
        public Licenca Licenca { get; set; }

        public DateTime Datum { get; set; }

        public string NazivTabele => "MajstorLicence";

        public string Vrednosti => $"{MajstorId}, {LicencaId}, '{Datum:yyyy-MM-dd}'";

        public string Kolone => "(MajstorId, LicencaId, Datum)";

        public string Output => "";
    }
}
