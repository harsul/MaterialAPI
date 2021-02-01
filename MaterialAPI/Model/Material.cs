using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterialAPI.Model
{
    public class Material
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Quality { get; set; }
        public long Price { get; set; }
    }
}
