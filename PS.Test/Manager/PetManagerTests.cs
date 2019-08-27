using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PS.Domain;
using PS.Manager;

namespace PS.Test.Manager
{
    [TestClass]
    public class PetManagerTests: TestBase
    {

        [TestMethod]
        public void TestMethod2()
        {
            var tes = PetManager.GetAllPets();
        }
    }
}
