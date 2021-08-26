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
            string result = class1.GetVersionNumber(input);
            Assert.IsNotNull(result);
        }
    }
}
