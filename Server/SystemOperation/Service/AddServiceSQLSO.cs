using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class AddServiceSQLSO : SystemOperationBaseSQL
    {

        protected override void Izvrsi(object obj)
        {
            var service = (Servis)obj;
            int id= repo.Sacuvaj(service);
            foreach(var stavka in service.Stavke)
            {
                stavka.ServisId = id;
                repo.Sacuvaj(stavka);
            }


        }
    }
}
