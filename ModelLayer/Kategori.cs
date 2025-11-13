using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ModelLayer
{
    public class Kategori
    {
        public string? Id { get; set; }
        public string? Namn { get; set; }
        public List<Podd>? Poddar { get; set; } = new();
    }
}
