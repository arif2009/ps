using System.Collections.Generic;
using PS.Domain;
using PS.Model;
using PS.Utility;

namespace PS.Manager
{
    public class PetManager : IPetManager
    {
        private IPetRepository _petRepository;

        public PetManager(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public List<Pet> GetAllPets()
        {
            return _petRepository.GetAllPets();
        }

        public List<Pet> GetBirds()
        {
            return this.GetUnSoldablePets().FindAll(x=>x.PetType == PetTypes.Bird);
        }

        public List<Pet> GetCats()
        {
            return this.GetUnSoldablePets().FindAll(x => x.PetType == PetTypes.Cat);
        }

        public List<Pet> GetDogs()
        {
            return this.GetUnSoldablePets().FindAll(x => x.PetType == PetTypes.Dog);
        }

        public List<Pet> GetSoldPets()
        {
            return _petRepository.GetAllPets().FindAll(x => x.IsSold);
        }

        public List<Pet> GetUnSoldablePets()
        {
            return _petRepository.GetAllPets().FindAll(x => !x.IsSold);
        }
    }
}
