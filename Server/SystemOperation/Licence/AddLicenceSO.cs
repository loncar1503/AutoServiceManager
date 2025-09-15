using Common.Domain;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Licence
{
    internal class AddLicenceSO:SystemOperationBase
    {
        MajstorLicenca ml;


        public AddLicenceSO(MajstorLicenca ml)
        {
            this.ml = ml;
        }

        protected override void ExecuteConcreteOperation()
        {
            AddLicence(ml);
        }

        public void AddLicence(MajstorLicenca ml)
        {
            Licenca l = ml.Licenca;
            context.Licence.Add(l);
            context.SaveChanges();

            MajstorLicenca novaLicenca = new MajstorLicenca()
            {
                LicencaId = l.Id,
                MajstorId = ml.MajstorId,
                Datum = DateTime.Now
            };
            context.MajstorLicence.Add(novaLicenca);
        }
    }
}
