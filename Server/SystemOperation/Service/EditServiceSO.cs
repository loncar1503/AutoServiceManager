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

            context.RemoveRange(db.Stavke);   


            db.Stavke = servis.Stavke;
            db.OpisProblema = servis.OpisProblema;
            db.DatumPrijema = servis.DatumPrijema;
            db.UkupnaCena = servis.UkupnaCena;
            db.MajstorId = servis.MajstorId;
            db.VoziloRegBroj = servis.VoziloRegBroj;
        }
    }
}
