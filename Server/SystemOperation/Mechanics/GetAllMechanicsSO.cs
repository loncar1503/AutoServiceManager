using Common.Domain;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Mechanics
{
    internal class GetAllMechanicsSO: SystemOperationBase
    {
        public List<Majstor> Result { get; set; }

        public GetAllMechanicsSO()
        {

        }
        protected override void ExecuteConcreteOperation()
        {
            Result = context.Majstori.ToList();
        }
    }
}
