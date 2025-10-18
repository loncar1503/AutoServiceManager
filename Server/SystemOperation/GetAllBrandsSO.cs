using Common.Domain;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class GetAllBrandsSO : SystemOperationBase
    {
        public List<Marka> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result= context.Marke.OrderBy(x => x.Naziv).ToList();
        }
    }
}
