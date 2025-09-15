using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Vehicle
{
    public class AddVehicleSQLSO : SystemOperationBaseSQL
    {
        
        protected override void Izvrsi(object obj)
        {
            var vehicle= (Vozilo)obj;
            repo.Sacuvaj(vehicle);

        }
    }
}
