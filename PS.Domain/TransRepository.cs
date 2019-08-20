using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Model;

namespace PS.Domain
{
    public class TransRepository : ITransRepository
    {
        public List<Transaction> GetAllTransaction()
        {
            return Data.transactions;
        }
    }
}
