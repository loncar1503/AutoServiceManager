using Common.Domain;
using DBBroker;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Vehicle
{
    internal class EditVehicleSO : SystemOperationBase
    {
        public Vozilo Result { get; set; }
        public Vozilo vehicle;
       // private readonly AppDbContext context;


        public EditVehicleSO(Vozilo vozilo)
        {
            this.vehicle = vozilo;
           // context = new AppDbContext();

        }
        protected override void ExecuteConcreteOperation()
        {
            EditVehicle(vehicle);
        }

        public void EditVehicle(Vozilo incoming)
        {
            var dbVozilo = context.Vozila
                .Include(v => v.Klijent)
                .FirstOrDefault(v => v.RegBroj == incoming.RegBroj);

            if (dbVozilo == null)
                throw new Exception("Vozilo nije pronađeno.");

            dbVozilo.GodinaProizvodnje = incoming.GodinaProizvodnje;
            dbVozilo.ModelVozilaId = incoming.ModelVozilaId;   


            if (incoming.KlijentId == dbVozilo.KlijentId)
            {
                if (incoming.Klijent != null)
                {
                    dbVozilo.Klijent.Ime = incoming.Klijent.Ime;
                    dbVozilo.Klijent.Prezime = incoming.Klijent.Prezime;
                    dbVozilo.Klijent.BrojTelefona = incoming.Klijent.BrojTelefona;
                }
            }
            else
            {
                var novi = context.Klijenti.FirstOrDefault(k => k.Id == incoming.KlijentId);
                if (novi == null)
                    throw new Exception("Izabrani klijent ne postoji.");

                if (incoming.Klijent != null)
                {
                    novi.Ime = incoming.Klijent.Ime;
                    novi.Prezime = incoming.Klijent.Prezime;
                    novi.BrojTelefona = incoming.Klijent.BrojTelefona;
                }

                dbVozilo.KlijentId = novi.Id;     
                                                 
            }
        }
    }
}
