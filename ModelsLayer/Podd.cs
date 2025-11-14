using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Podd
    {
        public string? Id { get; set; } 
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? CategoryId { get; set; }
        public List<Episode>? Episodes { get; set; } = new();
    }
}
