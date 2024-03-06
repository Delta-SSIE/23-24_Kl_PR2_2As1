using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Unit_testing_02_Rychlostni_skrin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unit_testing_02_Rychlostni_skrin.Tests
{
    [TestClass()]
    public class RychlostniSkrinTests
    {
        [TestMethod()]
        public void RychlostniSkrinInitOtackyTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            Assert.AreEqual(1600, rs.MaxOtackyRazeni);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RychlostniSkrinInitNegativeTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(-1600);
            Assert.Fail();
        }

        [TestMethod()]
        public void RychlostniSkrinInitZarazenoTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            Assert.AreEqual(Stupen.Neutral, rs.Zarazeno);
        }

        [TestMethod()]
        public void NahoruTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Nahoru();
            Assert.AreEqual(Stupen.Jednicka, rs.Zarazeno);
        }

        [TestMethod()]
        public void NahoruVicTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            for (int i = 0; i < 6; i++)
            {
                rs.Nahoru();
            }            
            Assert.AreEqual(Stupen.Sestka, rs.Zarazeno);
        }

        [TestMethod()]
        public void AzNahoruTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            for (int i = 0; i < 7; i++)
            {
                rs.Nahoru();
            }
            Assert.AreEqual(Stupen.Sestka, rs.Zarazeno);
        }

        [TestMethod()]
        public void NahoruMaxOtackyTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Otacky = 2000;
            rs.Nahoru();
            Assert.AreEqual(Stupen.Neutral, rs.Zarazeno);
        }

        [TestMethod()]
        public void DoluTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Dolu();
            Assert.AreEqual(Stupen.Zpatecka, rs.Zarazeno);
        }

        [TestMethod()]
        public void AzDoluTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Dolu();
            rs.Dolu();
            Assert.AreEqual(Stupen.Zpatecka, rs.Zarazeno);
        }

        [TestMethod()]
        public void DoluMaxOtackyTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Otacky = 2000;
            rs.Dolu();
            Assert.AreEqual(Stupen.Neutral, rs.Zarazeno);
        }


        [TestMethod()]
        public void OtackySetTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Otacky = 200;
            Assert.AreEqual(200, rs.Otacky);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OtackySetNegativeTest()
        {
            RychlostniSkrin rs = new RychlostniSkrin(1600);
            rs.Otacky = -200;
            Assert.Fail();
        }
    }
}