using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonovalovaAO.Sprint1.Task2.V21.Lib;

namespace Tyuiu.KonovalovaAO.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 7;
            var res = ds.CalculateRectangleSquare(a, b);
            Assert.AreEqual(35, res);
        }
    }
}
