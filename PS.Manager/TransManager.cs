using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Domain;
using PS.Model;

namespace PS.Manager
{
    public class TransManager : ITransManager
    {
        private ITransRepository _transRepository;
        public TransManager(ITransRepository transRepository)
        {
            _transRepository = transRepository;
        }
        public List<Transaction> GetAllTransaction()
        {
            return _transRepository.GetAllTransaction();
        }
    }
}
