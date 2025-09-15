using Common.Domain;
using DBBroker;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class AddServiceSO: SystemOperationBase
    {
        public Servis servis;
        //private readonly AppDbContext context;

        public AddServiceSO(Servis servis)
        {
            this.servis = servis;
           // context = new AppDbContext();
        }
        protected override void ExecuteConcreteOperation()
        {
            context.Servisi.Add(servis); 
        }
    }
}
