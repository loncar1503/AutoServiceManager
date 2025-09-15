using Common.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Vehicle
{
    internal class GetVehicleSO : SystemOperationBase
    {
        public Vozilo Result { get; private set; }
        public Vozilo vozilo;

        public GetVehicleSO(Vozilo v)
        {
            vozilo = v;
        
        }  

        protected override void ExecuteConcreteOperation()
        {
            // sve za prikaz u gridu / formi:
            Result = context.Vozila
                .Include(v => v.Klijent)
                .Include(v => v.ModelVozila)
                    .ThenInclude(m => m.Marka)
                .AsNoTracking()
                .FirstOrDefault(v => v.RegBroj == vozilo.RegBroj);

            if (Result == null)
                throw new Exception("Vozilo nije pronađeno.");
        }
    }
}

