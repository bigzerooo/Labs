using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace HelloWorldTests
{
    [TestClass]
    public class Tests
    {        

        [TestMethod]
        public void Test4()
        {
            string expected = "Red";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PrintYourColor.Main();

                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void Test5()
        {
            string expected = $"{-100}\n{128}\n{-3540}\n{64876}\n{2147483648}\n{-1141583228}\n{-1223372036854775808}";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Problem5.Main();

                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void Test6()
        {
            string expected = $"{3.141592653589793238}\n{1.60217657f}\n{7.8184261974584555216535342341m}";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Problem6.Main();

                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void Test7()
        {
            string expected = "Software University\nB\ny\ne\nI love programming";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Problem7.Main();

                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }
    }
}