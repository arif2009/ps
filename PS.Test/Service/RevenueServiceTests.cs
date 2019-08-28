using System;
using System.Collections.Generic;
using NUnit.Framework;
using PS.Model;
using PS.Model.VMs;
using PS.Utility;

namespace PS.Test.Service
{
    public class RevenueServiceTests: TestBase
    {
        [OneTimeSetUp]
        public void Initialization()
        {
            Data.pets = new List<Pet>
            {
                new Pet{ Id = 1, Name = "Pamela", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2017,09,22), ChipIdentifier = "MYR90JLI2ZL", InplanteDate = new DateTime(2018,01,08), Price = 2324, Description = "penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin vel nisl. Quisque fringilla euismod", CrietedDate = new DateTime(2018,08,21) },
                new Pet{ Id = 2, Name = "Wyoming", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2019,01,23), ChipIdentifier = "DMN76FBI1QW", InplanteDate = new DateTime(2018,06,07), Price = 1531, Description = "Proin dolor. Nulla semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique", CrietedDate = new DateTime(2018,10,09) },
                new Pet{ Id = 3, Name = "Britanni", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2018,05,13), ChipIdentifier = "UKN24GBC3HH", InplanteDate = new DateTime(2018,09,29), Price = 3268, Description = "lectus justo eu arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus", CrietedDate = new DateTime(2019,08,12) }
            };

            Data.transactions = new List<Transaction>
            {
                new Transaction { Id = 1, PetId = 2, UserId = 5, CrietedDate = new DateTime(2019,08,24), TransType = TransTypes.ByUpfront },
                new Transaction { Id = 2, PetId = 1, UserId = 4, CrietedDate = new DateTime(2019,08,14), TransType = TransTypes.ByCash },
                new Transaction { Id = 3, PetId = 3, UserId = 4, CrietedDate = new DateTime(2019,08,15), TransType = TransTypes.ByUpfront }
            };
        }

        [Test]
        public void RevinueShouldHaveObject()
        {
            var sut = RevenueService.GetRevinueBetween(new DateTime(2019, 08, 14), new DateTime(2019, 08, 24));

            Assert.That(sut, Is.Not.Null);
            Assert.That(sut, Is.TypeOf<ReportVm>());
        }
    }
}
