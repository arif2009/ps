using PS.Utility;
using System;

namespace PS.Model
{
    public class User: PetBase
    {
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string SSN { get; set; } //SSN = Social Security Number
        public Roles Role { get; set; } = Roles.Customer; // Set Customer as a default role
    }
}
