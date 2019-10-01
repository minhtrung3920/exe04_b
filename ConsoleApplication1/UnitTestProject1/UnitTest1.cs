using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstraint5()
        {
            int[] arr = new int[] {1,2,3,4,6,5};
            bool result = Program.IsConstraint5(arr);
            Assert.AreEqual(true, result);
            
        }
       
    }
}
