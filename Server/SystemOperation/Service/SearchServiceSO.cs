using Common.Domain;
using Common.Domain.DTO;
using DBBroker;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class SearchServiceSO: SystemOperationBase
    {
        public List<Servis> Result { get; set; }
        public ServisFilter filter;
        //private readonly AppDbContext context;

        public SearchServiceSO(ServisFilter filter)
        {
            this.filter = filter;
            //context = new AppDbContext();

        }
        protected override void ExecuteConcreteOperation()
        {
            Result = SearchService(filter);
        }

        public List<Servis> SearchService(ServisFilter f)
        {
            IQueryable<Servis> q = context.Servisi;

            // Datumski filter
            if (f.DateFrom.HasValue)
                q = q.Where(s => s.DatumPrijema >= f.DateFrom.Value.Date);

            if (f.DateTo.HasValue)
            {
                var end = f.DateTo.Value.Date.AddDays(1); 
                q = q.Where(s => s.DatumPrijema < end);
            }

            if (!string.IsNullOrWhiteSpace(f.Query))
            {
                var txt = f.Query.Trim();
                var like = $"%{txt}%";

                q = q.Where(s =>
                    EF.Functions.Like(s.VoziloRegBroj, like) ||                    
                    EF.Functions.Like(s.Majstor.Ime + " " + s.Majstor.Prezime, like) || 
                    EF.Functions.Like(s.Vozilo.ModelVozila.Naziv, like) ||        
                    EF.Functions.Like(s.Vozilo.ModelVozila.Marka.Naziv, like)      
                );
            }

         
            return q.Include(s => s.Majstor)
                    .Include(s => s.Vozilo).ThenInclude(v => v.ModelVozila).ThenInclude(m => m.Marka)
                    .AsNoTracking()
                    .AsSplitQuery()
                    .OrderByDescending(s => s.DatumPrijema)
                    .ToList();
        }
    }
}
