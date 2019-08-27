using NUnit.Framework;
using PS.Model;
using PS.Utility;
using System;
using System.Collections.Generic;

namespace PS.Test.Manager
{
    [TestFixture]
    public class UserManagerTests: TestBase
    {
        [OneTimeSetUp]
        public void Initialization()
        {
            Data.userList = new List<User>
            {
                new User { Id = 1, Name = "Barrett Klein", Role = Roles.Owner, ContactNo = "042-714-9748", Address = "P.O. Box 198, 543 Nisi. Rd.", SSN = "B7556371-422C-F852-D1C5-938203EB2063", CrietedDate = new DateTime(2019, 08, 21) },
                new User { Id = 2, Name = "Jesse Richardson", Role = Roles.Customer, ContactNo = "071-851-1175", Address = "Ap #385-8107 Magna. St.", SSN = "31CEF7B2-3061-F3EC-D95D-05357736DC58", CrietedDate = new DateTime(2018,08,30) },
                new User { Id = 3, Name = "Kennan Sparks", Role = Roles.Customer, ContactNo = "077-066-6786", Address = "Ap #912-2912 Nulla Road", SSN = "47511F9A-1E0B-54B0-73BC-9C961F326B75", CrietedDate = new DateTime(2019,04,24) }
            };
        }

        [Test]
        public void ShouldAllCustomer()
        {
            var sut = UserManager.GetAllCustomer();
            var customerList = Data.userList.FindAll(x => x.Role == Roles.Customer);

            Assert.AreEqual(sut, customerList);
        }

        [Test]
        public void ShouldOwner()
        {

        }
    }
}
