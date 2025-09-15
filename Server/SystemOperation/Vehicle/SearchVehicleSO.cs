using Common.Domain.DTO;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Server.SystemOperation.Vehicle
{
    public class SearchVehicleSO: SystemOperationBase
    {
        public List<Vozilo> Result { get; set; }
        public VehicleFilter filter;
        //private readonly AppDbContext context;

        public SearchVehicleSO(VehicleFilter filter)
        {
            this.filter = filter;
            //context = new AppDbContext();

        }
        protected override void ExecuteConcreteOperation()
        {
            Result = SearchVehicle(filter);
        }

        private List<Vozilo> SearchVehicle(VehicleFilter f)
        {
            IQueryable<Vozilo> q = context.Vozila;

            if (!string.IsNullOrWhiteSpace(f.Query))
            {
                var txt = f.Query.Trim();
                var like = $"%{txt}%";

              
                if (int.TryParse(txt, out var year))
                {
                    q = q.Where(v =>
                        EF.Functions.Like(v.RegBroj, like) ||
                        EF.Functions.Like(v.ModelVozila.Naziv, like) ||
                        EF.Functions.Like(v.ModelVozila.Marka.Naziv, like) ||
                        EF.Functions.Like(v.Klijent.Ime + " " + v.Klijent.Prezime, like) ||
                        v.GodinaProizvodnje == year
                    );
                }
                else
                {
                    q = q.Where(v =>
                        EF.Functions.Like(v.RegBroj, like) ||
                        EF.Functions.Like(v.ModelVozila.Naziv, like) ||
                        EF.Functions.Like(v.ModelVozila.Marka.Naziv, like) ||
                        EF.Functions.Like(v.Klijent.Ime + " " + v.Klijent.Prezime, like)
                    );
                }
            }

            return q.Include(v => v.ModelVozila).ThenInclude(m => m.Marka)
                    .Include(v => v.Klijent)
                    .AsNoTracking()
                    .AsSplitQuery()
                    .OrderBy(v => v.RegBroj) 
                    .ToList();
        }
    }
}
