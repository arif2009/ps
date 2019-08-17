using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Model
{
    public class Showroom: PetBase
    {
        public string Description { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }
}
