using PS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Model
{
    public class Transaction: PetBase
    {
        public long PetId { get; set; }
        public long UserId { get; set; }
        public TransTypes TransType { get; set; }
    }
}
