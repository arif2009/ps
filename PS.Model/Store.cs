using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Model
{
    public class Store:PetBase
    {
        public Showroom Showroom { get; set; }
        public Backyard Backyard { get; set; }
    }
}
