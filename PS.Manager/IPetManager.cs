using PS.Model;
using System;
using System.Collections.Generic;
using PS.Model.VMs;

namespace PS.Manager
{
    public interface IPetManager
    {
        IEnumerable<Pet> GetAllPets();
        IEnumerable<PetVm> GetSoldPets();
        IEnumerable<Pet> GetUnSoldablePets();
    }
}
