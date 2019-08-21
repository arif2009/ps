using System.Collections.Generic;
using System.Linq;
using PS.Domain;
using PS.Model;
using PS.Utility;

namespace PS.Manager
{
    public class PetManager : IPetManager
    {
        private IPetRepository _petRepository;
        private ITransRepository _transRepository;

        public PetManager(IPetRepository petRepository, ITransRepository transRepository)
        {
            _petRepository = petRepository;
            _transRepository = transRepository;
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
            return _petRepository.GetAllPets().Join(_transRepository.GetAllTransaction(), p => p.Id, t => t.PetId, (p, t) => p).ToList();
        }

        public List<Pet> GetUnSoldablePets()
        {
            var match = this.GetSoldPets().Select(y => new { y.Id });
            return _petRepository.GetAllPets().Where(x => !match.Contains(new { x.Id })).ToList();
        }
    }
}
