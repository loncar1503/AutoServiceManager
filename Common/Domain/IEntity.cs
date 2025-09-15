using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string NazivTabele { get; }
        string Vrednosti { get; }
       
        string Kolone { get; }
    
        string Output { get; }

    }
}
