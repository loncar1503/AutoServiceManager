using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class MajstorLicenca
    {
        public int MajstorId { get; set; }
        public Majstor Majstor { get; set; }

        public int LicencaId { get; set; }
        public Licenca Licenca { get; set; }

        public DateTime Datum { get; set; }

    }
}
