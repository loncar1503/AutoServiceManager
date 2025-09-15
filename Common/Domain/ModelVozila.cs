using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class ModelVozila
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public int MarkaId { get; set; }
        public Marka Marka { get; set; }

        public List<Vozilo> Vozila { get; set; } = new();
        public override string ToString()
        {
            return Naziv;
        }
    }
}
