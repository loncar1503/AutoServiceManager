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
    internal class EditServiceSO: SystemOperationBase
    {
        public Servis servis;
        

        public EditServiceSO(Servis servis)
        {
            this.servis = servis;
           
        }
        protected override void ExecuteConcreteOperation()
        {
            var db = context.Servisi
                .Include(s => s.Stavke)            
                .FirstOrDefault(s => s.Id == servis.Id);
            if (db == null) throw new Exception("Servis ne postoji.");

            var keepIds = (servis.Stavke ?? new List<StavkaServisa>())
                    .Where(x => x.Id > 0)
                    .Select(x => x.Id)
                    .ToList();

            foreach (var old in db.Stavke.Where(ss => !keepIds.Contains(ss.Id)).ToList())
                context.StavkeServisa.Remove(old);
            var nove = (servis.Stavke ?? new List<StavkaServisa>())
                .Where(x => x.Id == 0)
                .ToList();

            foreach (var n in nove)
            {
                n.Id = 0;                  
                n.ServisId = db.Id;
                n.Usluga = null;          
                db.Stavke.Add(n);
            }

            int rb = 1;
            foreach (var st in db.Stavke.OrderBy(x => x.Rb).ThenBy(x => x.Id))
                st.Rb = rb++;
         
            db.OpisProblema = servis.OpisProblema;
            db.DatumPrijema = servis.DatumPrijema;
            db.UkupnaCena = servis.UkupnaCena;
            db.MajstorId = servis.MajstorId;
            db.VoziloRegBroj = servis.VoziloRegBroj;
        }
    }
}
