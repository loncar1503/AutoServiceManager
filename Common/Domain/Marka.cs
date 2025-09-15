using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Marka
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public List<ModelVozila> Modeli { get; set; } = new();

        public override string ToString()
        {
            return Naziv;
        }
    }
    
}
