using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Owner
{
    public class GetAllOwnersSO: SystemOperationBase
    {
        public List<Klijent> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = context.Klijenti.ToList();
        }
    }
}
