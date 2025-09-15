using Common.Domain;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class GetAllModelsSO: SystemOperationBase
    {
        public List<ModelVozila> Result { get; set; }
        //private readonly AppDbContext context;

        public GetAllModelsSO()
        {
           // context = new AppDbContext();


        }
        protected override void ExecuteConcreteOperation()
        {
            Result = context.ModeliVozila.ToList();
        }
    }
}
