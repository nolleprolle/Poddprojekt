using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelLayer
{
    public class Podd
    {
        public string? Id { get; set; }
        public string? Namn { get; set; }
        public string? Url { get; set; }
        public string? Kategori { get; set; }
        public List<Avsnitt>? Avsnitt { get; set; } = new();
    }
}
