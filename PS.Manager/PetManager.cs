using System.Collections.Generic;
using System.Linq;
using PS.Domain;
using PS.Model;
using PS.Model.VMs;
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

        public IEnumerable<Pet> GetAllPets()
        {
            return _petRepository.GetAllPets();
        }

        public IEnumerable<PetVm> GetSoldPets()
        {
            var pets = _petRepository.GetAllPets().Join(_transRepository.GetAllTransaction(), p => p.Id, t => t.PetId,
                (p, t) => new PetVm
                {
                    Id = p.Id, DateOfBirth = p.DateOfBirth,
                    InplanteDate = p.InplanteDate, SoldDate = t.CrietedDate,
                    Price = p.Price,
                    PetType = p.PetType, TransType = t.TransType
                }).ToList();

            return pets;
        }

        public IEnumerable<Pet> GetUnSoldablePets()
        {
            var match = this.GetSoldPets().Select(y => new { y.Id });
            return _petRepository.GetAllPets().Where(x => !match.Contains(new { x.Id }));
        }
    }
}
