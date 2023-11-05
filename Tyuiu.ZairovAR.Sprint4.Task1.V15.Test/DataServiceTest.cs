using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint4.Task1.V15.Lib;
namespace Tyuiu.ZairovAR.Sprint4.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5 };
            int res = ds.Calculate(array);
            int wait = 41472;
            Assert.AreEqual(wait, res);
        }
    }
}
