using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonovalovaAO.Sprint1.Task6.V8.Lib;

namespace Tyuiu.KonovalovaAO.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "Локи бог обмана";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "оки бог обманаЛ";
            Assert.AreEqual(wait, res);
        }
    }
}
