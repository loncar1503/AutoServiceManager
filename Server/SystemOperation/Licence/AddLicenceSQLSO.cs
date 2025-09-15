using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Licence
{
    internal class AddLicenceSQLSO : SystemOperationBaseSQL
    {
        protected override void Izvrsi(object obj)
        {
            var ml = (MajstorLicenca)obj;
            int licencaId = repo.Sacuvaj(ml.Licenca);
            MajstorLicenca novaML = new MajstorLicenca()
            {
                MajstorId = ml.MajstorId,
                LicencaId=licencaId,
                Datum=DateTime.Now,

            };
            repo.Sacuvaj(novaML);
        }
    }
}
