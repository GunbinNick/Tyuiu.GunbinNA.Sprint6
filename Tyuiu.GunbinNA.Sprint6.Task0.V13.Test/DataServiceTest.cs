using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint6.Task0.V13.Lib;
namespace Tyuiu.GunbinNA.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.Calculate(x);
            var wait = 3.375;
            Assert.AreEqual(wait, res);
        }
    }
}
