using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Licenca
    {
        public int Id { get; set; }  // idLicence
        public string Naziv { get; set; }
        public string Institucija { get; set; }
        public string Kategorija { get; set; }
        

        public List<MajstorLicenca> MajstorLicenca { get; set; }


    }
}
