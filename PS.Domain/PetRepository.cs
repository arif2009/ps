using System;
using System.Collections.Generic;
using PS.Model;

namespace PS.Domain
{
    public class PetRepository : IPetRepository
    {
        public List<Pet> GetAllPets()
        {
            return Data.pets;
        }
    }
}
