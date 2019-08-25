using System;
using PS.Utility;

namespace PS.Model.VMs
{
    public class PetVm:Pet
    {
        public DateTime SoldDate { get; set; }
        public TransTypes TransType { get; set; }
    }
}
