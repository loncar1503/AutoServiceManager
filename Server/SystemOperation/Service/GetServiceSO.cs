using Common.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class GetServiceSO : SystemOperationBase
    {
        public Servis Result { get; set; }
        Servis servis;
        public GetServiceSO(Servis s)
        {
            servis = s;

        }
        protected override void ExecuteConcreteOperation()
        {
            Result = context.Servisi
               .Include(s => s.Majstor)      
               .Include(s => s.Vozilo)
                   .ThenInclude(v => v.ModelVozila)
                       .ThenInclude(m => m.Marka)
                .Include(s => s.Vozilo)                
                    .ThenInclude(v => v.Klijent)
               .Include(s => s.Stavke)
                   .ThenInclude(st => st.Usluga)
               .AsNoTracking()      
               .AsSplitQuery()
               .SingleOrDefault(s => s.Id == servis.Id);

            if (Result == null)
                throw new Exception("Servis nije pronađen.");
        }
    }
}
