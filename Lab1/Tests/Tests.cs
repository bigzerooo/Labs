using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Linq;

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

        [DataTestMethod]
        [DataRow(40, 41, 20)]
        [DataRow(22, 52, 60)]
        public void Test8(int a, int b, int c)
        {
            string expected = ((a + b + c) / 3f).ToString();
            using (var sw = new StringWriter())
            {
                using(var sr = new StringReader($"{a}\n{b}\n{c}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem8.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [DataTestMethod]
        [DataRow(5, 2, 4)]
        [DataRow(8.5f, 4.4f, 2)]
        public void Test9(float a, float b, float h)
        {
            string expected = ((a+b)/2*h).ToString();
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{a}\n{b}\n{h}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem9.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);                
                
            }
        }

        [DataTestMethod]
        [DataRow(21)]
        [DataRow(139)]
        [DataRow(4)]
        public void Test10(int n)
        {
            string expected = (n%10).ToString();
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{n}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem10.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);

            }
        }

        [DataTestMethod]
        [DataRow(2174, 3)]
        [DataRow(169, 2)]
        [DataRow(46, 4)]
        public void Test11(int number, int n)
        {
            string expected = (number/ (int)Math.Pow(10,n-1)%10).ToString();
            if (number.ToString().Length < n || n <= 0)
                expected = "-";
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{number}\n{n}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem11.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);

            }
        }

        [DataTestMethod]
        [DataRow(63)]
        [DataRow(17)]
        [DataRow(22)]
        [DataRow(23)]        
        public void Test12(int n)
        {
            string expected = (n>20&&n%2==1).ToString();            
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{n}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem12.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);

            }
        }

        [DataTestMethod]
        [DataRow(121)]
        [DataRow(1263)]
        [DataRow(26)]
        [DataRow(23)]
        [DataRow(81)]
        [DataRow(1287)]
        public void Test13(int n)
        {
            string expected = (n%9==0||n%11==0||n%13==0).ToString();
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{n}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem13.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);

            }
        }

        [DataTestMethod]
        [DataRow(45,41,20)]
        [DataRow(22,52,60)]        
        public void Test14(int a, int b, int c)
        {
            string expected = new int[] { a, b, c }.Max().ToString();
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{a}\n{b}\n{c}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem14.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [DataTestMethod]
        [DataRow(5, 2, 4)]
        [DataRow(8.5f, 4.4f, -2)]
        [DataRow(2.7f, -0.1f, -9)]
        public void Test15(float a, float b, float c)
        {
            string expected = new float[] { a,b,c}.Count(x => x < 0) % 2 == 0 ? "Positive" : "Negative";
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{a}\n{b}\n{c}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem15.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [DataTestMethod]
        [DataRow("2")]
        [DataRow("1")]
        [DataRow("0")]
        [DataRow("5")]
        [DataRow("-0.1")]
        public void Test16(string d)
        {
            string expected = d switch
            {
                "1" => "Monday",
                "2" => "Tuesday",
                "3" => "Wednesday",
                "4" => "Thursday",
                "5" => "Friday",
                "6" => "Saturday",
                "7" => "Sunday",
                _ => "Not valid"
            };
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{d}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem16.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(6)]        
        public void Test17(int n)
        {
            string expected = Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item).ToString();
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader($"{n}"))
                {
                    Console.SetIn(sr);
                    Console.SetOut(sw);
                    Problem17.Main();
                }
                string result = sw.ToString().Trim();

                Assert.AreEqual(expected, result);
            }
        }
    }
}