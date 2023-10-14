using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint1.Task4.v30.Lib;
namespace Tyuiu.KonovalovaAO.Sprint1.Task4.v30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidEspression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(76, 112, res);

        }
    }
}
