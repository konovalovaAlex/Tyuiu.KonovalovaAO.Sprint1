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
            string srt = "мир";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(srt);
            string wait = "рим";
            Assert.AreEqual(wait, res);
        }
    }
}
