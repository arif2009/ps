using PS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Manager
{
    public interface ITransManager
    {
        List<Transaction> GetAllTransaction();
    }
}
