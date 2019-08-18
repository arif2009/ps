using PS.Model;
using System;
using System.Collections.Generic;

namespace PS.Manager
{
    public interface IPetManager
    {
        List<Pet> GetAllPets();
        List<Pet> GetSoldPets();
        List<Pet> GetUnSoldablePets();
        List<Pet> GetDogs();
        List<Pet> GetCats();
        List<Pet> GetBirds();
    }
}
