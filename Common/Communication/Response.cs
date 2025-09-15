using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Response
    {
        public bool Signal { get; set; } = true;

        public object Result { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
