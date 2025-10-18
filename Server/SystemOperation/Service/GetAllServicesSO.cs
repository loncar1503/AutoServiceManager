using Common.Domain;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class GetAllServicesSO: SystemOperationBase
    {
        public List<Servis> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = context.Servisi.Include(s => s.Majstor).Include(s => s.Vozilo).ThenInclude(v => v.ModelVozila).ThenInclude(m => m.Marka).OrderByDescending(s => s.DatumPrijema).ToList();
        }
    }
}
