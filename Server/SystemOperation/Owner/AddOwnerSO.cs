using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Owner
{
    internal class AddOwnerSO: SystemOperationBase
    {
        public Klijent owner;
        //private readonly AppDbContext context;

        public AddOwnerSO(Klijent owner)
        {
            this.owner = owner;
            // context = new AppDbContext();
        }
        protected override void ExecuteConcreteOperation()
        {
            context.Klijenti.Add(owner);
        }
    }
}
