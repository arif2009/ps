using PS.Model;
using System;
using System.Collections.Generic;

namespace PS.Manager
{
    public interface IPetManager
    {
        List<Pet> GetAllPets();
    }
}
