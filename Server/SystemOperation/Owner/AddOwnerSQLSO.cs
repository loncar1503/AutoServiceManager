using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Owner
{
    public class AddOwnerSQLSO : SystemOperationBaseSQL
    {
        public int Rezultat { get; private set; }

        protected override void Izvrsi(object obj)
        {
            var owner = (Klijent)obj;
            Rezultat= repo.Sacuvaj(owner);
        }
    }
}
