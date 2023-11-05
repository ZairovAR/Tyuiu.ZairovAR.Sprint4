using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint4.Task2.V8.Lib;
namespace Tyuiu.ZairovAR.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] a = { 1, 2, 3, 4, 3, 3, 3, 3 };
            int res = ds.Calculate(a);
            int b = 15;

            Assert.AreEqual(res, b);
        }
    }
}
