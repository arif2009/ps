using PS.Manager;
using PS.Model;
using PS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Model.VMs;
using CONST = PS.Utility.Constants;

namespace PS.Service
{
    public class RevenueService: IRevenueService
    {
        private IPetManager _petManager;
        private ITransManager _transManager;
        public RevenueService(IPetManager petManager, ITransManager transManager)
        {
            _petManager = petManager;
            _transManager = transManager;
        }

        public ReportVm GetRevinueBetween(DateTime dateFrom, DateTime dateTo)
        {
            var soldPets = _petManager.GetSoldPets().Where(x => x.SoldDate.Between(dateFrom, dateTo));
            var soldByInsurance = soldPets.Where(x => x.TransType == TransTypes.ByInsurance);

            var soldByCashPrice = soldPets.Where(x => x.TransType == TransTypes.ByCash).Sum(x=>x.Price);
            var soldByInsurancePrice = soldByInsurance.Sum(x => (x.Price * 20 / 100) + CONST.INSURENCE_COST); // 100%-80% cash back = 20%
            var soldByUpFrontPrice = soldPets.Where(x => x.TransType == TransTypes.ByUpfront).Sum(x => x.Price * 20 / 100); // 20%  up-front

            var revenue = soldByCashPrice + soldByInsurancePrice + soldByUpFrontPrice;
            var immobilizedMoney = soldByInsurance.Sum(x => x.Price) - soldByInsurance.Sum(x => (x.Price * 20 / 100));

            return new ReportVm
            {
                Revenue = revenue,
                Immobilized = immobilizedMoney
            };
        }
    }
}
