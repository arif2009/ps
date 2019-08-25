using PS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Model.VMs;

namespace PS.Service
{
    public interface IRevenueService
    {
        ReportVm GetRevinueBetween(DateTime dateFrom, DateTime dateTo);
    }
}
