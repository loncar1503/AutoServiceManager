using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class DeleteServiceSO : SystemOperationBase
    {
        public Servis service;
        public DeleteServiceSO(Servis service)
        {
            this.service = service;
        }
        protected override void ExecuteConcreteOperation()
        {
            var s = context.Servisi.FirstOrDefault(s =>s.Id  == service.Id)
                      ?? throw new Exception("Vozilo nije pronađeno.");

            context.Servisi.Remove(s);
        }
    }
}
