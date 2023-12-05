using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint6.Task1.V14.Lib;


namespace Tyuiu.GunbinNA.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            var res = ds.GetMassFunction(start, stop);
            double[] wait = { -2.15, -2.57, -3, -3.83, -11.7, 0, 2.19, 3.31, 2.97, 1.18, 0.03 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
