using Common.Domain;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Service
{
    internal class GetAllJobsSO: SystemOperationBase
    {
       // private readonly AppDbContext context;

        public GetAllJobsSO()
        {
            //context = new AppDbContext();
        }
        public List<Usluga> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = context.Usluge.ToList();
        }
    }
}
