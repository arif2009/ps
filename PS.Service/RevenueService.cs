using PS.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Service
{
    public class RevenueService
    {
        private IPetManager _petManager;
        private ITransManager _transManager;
        public RevenueService(IPetManager petManager, ITransManager transManager)
        {
            _petManager = petManager;
            _transManager = transManager;
        }
    }
}
