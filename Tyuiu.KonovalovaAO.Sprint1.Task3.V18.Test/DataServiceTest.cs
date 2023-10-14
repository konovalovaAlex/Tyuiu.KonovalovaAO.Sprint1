using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint1.Task3.V18.Lib;
namespace Tyuiu.KonovalovaAO.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidEspression()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 4;
            double c = 2;
            double wait = 2;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }

}
}
