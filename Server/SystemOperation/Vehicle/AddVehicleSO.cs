using Common.Domain;
using DBBroker;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Vehicle
{
    internal class AddVehicleSO: SystemOperationBase
    {
        public Vozilo Result {  get; set; }
        public Vozilo vehicle;
       // private readonly AppDbContext context;


        public AddVehicleSO(Vozilo vozilo)
        {
            this.vehicle = vozilo;
           // context = new AppDbContext();
        }
        protected override void ExecuteConcreteOperation()
        {
            AddVehicle(vehicle);
        }

        public void AddVehicle(Vozilo vozilo)
        {
            var klijent = vozilo.Klijent;
            context.Klijenti.Update(klijent);
            context.SaveChanges();


            vozilo.KlijentId = klijent.Id;
            vozilo.Klijent = null; // da EF ne pokuša ponovo insert
            context.Vozila.Add(vozilo);
            context.SaveChanges();


        }
    }
}
