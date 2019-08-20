using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Model;

namespace PS.Manager
{
    public class TransManager : ITransManager
    {
        private ITransManager _transManager;
        public TransManager(ITransManager transManager)
        {
            _transManager = transManager;
        }
        public List<Transaction> GetAllTransaction()
        {
            return _transManager.GetAllTransaction();
        }
    }
}
