using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileData;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Class1 class1 = new Class1();
        [TestMethod]
        public void TestMethod1()
        {
            string[] input = new string[] { "-v", "C:/test.txt" };
            string result = class1.GetVersionNumber(input[1]);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] input = new string[] { "-v", "C:/test.txt" };
            int result = class1.GetSize(input[1]);
            Assert.IsNotNull(result);
        }
    }
}
