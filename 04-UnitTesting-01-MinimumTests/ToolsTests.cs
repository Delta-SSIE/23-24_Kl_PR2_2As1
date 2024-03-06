using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_UnitTesting_01_Minimum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_UnitTesting_01_Minimum.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = [1, 2, 3, -120, 4, 7, 2];
            Assert.AreEqual(-120, Tools.FindMin(nums));

        }
        [TestMethod()]
        [ExpectedException(typeof(EmptyInputException))]
        public void FindMinEmptyTest()
        {
            int[] nums = [];
            Tools.FindMin(nums);
            Assert.Fail();

            
        }
    }
}