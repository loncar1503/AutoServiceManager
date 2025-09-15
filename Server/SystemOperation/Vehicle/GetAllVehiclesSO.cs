using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Vehicle
{
    internal class GetAllVehiclesSO : SystemOperationBase
    {
        public List<Vozilo> Result { get; set; }
       // private readonly AppDbContext context;

        public GetAllVehiclesSO()
        {
           // context = new AppDbContext();
        }
        protected override void ExecuteConcreteOperation()
        {
            Result= context.Vozila.Include(v=>v.Klijent).Include(v=>v.ModelVozila).ThenInclude(m=>m.Marka).ToList();
        }
    }
}
