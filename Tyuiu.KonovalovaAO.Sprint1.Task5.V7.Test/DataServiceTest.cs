using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KonovalovaAO.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidEspression()
        {
            
            double f = 48;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);           
            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
