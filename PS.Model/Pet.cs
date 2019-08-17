using PS.Utility;
using System;

namespace PS.Model
{
    public class Pet: PetBase
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ChipIdentifier { get; set; }
        public DateTime InplanteDate { get; set; }
        public long Price { get; set; }
        public string Description { get; set; }
        public bool IsSold { get; set; }
        public PetTypes PetType { get; set; }
    }
}
