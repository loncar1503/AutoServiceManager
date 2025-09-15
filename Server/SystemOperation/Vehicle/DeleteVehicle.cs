using Common.Domain;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Vehicle
{
    internal class DeleteVehicle :SystemOperationBase
    {
        public Vozilo vehicle;
       // private readonly AppDbContext context;

        public DeleteVehicle(Vozilo vehicle)
        {
            this.vehicle = vehicle;
            //context = new AppDbContext();

        }

        protected override void ExecuteConcreteOperation()
        {
            Delete(vehicle);
        }

        public void Delete(Vozilo vehicle)
        {
            // 1) Provera postojanja zavisnih servisa
            bool imaServisa = context.Servisi.Any(s => s.VoziloRegBroj == vehicle.RegBroj);
            if (imaServisa)
                throw new Exception("The vehicle cannot be deleted as it has existing services..");

            // 2) Učitaj i obriši samo vozilo
            var vozilo = context.Vozila.FirstOrDefault(v => v.RegBroj == vehicle.RegBroj)
                      ?? throw new Exception("Vozilo nije pronađeno.");

            context.Vozila.Remove(vozilo);
        }
    }
}
