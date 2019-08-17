using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Model
{
    public class PetBase
    {
        public long Id { get; set; }
        public DateTime CrietedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
