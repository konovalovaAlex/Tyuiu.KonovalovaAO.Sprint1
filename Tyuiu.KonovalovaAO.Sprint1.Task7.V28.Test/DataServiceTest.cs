using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonovalovaAO.Sprint1.Task7.V28.Lib;

namespace Tyuiu.KonovalovaAO.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double wait = 6.577;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
