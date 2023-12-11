using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GunbinNA.Sprint6.Task6.V15.Lib;

namespace Tyuiu.GunbinNA.Sprint6.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"c:\DataSprint6\InPutFileTask6V15.txt";
            string str = "";
            var res = ds.CollectTextFromFile(str, path);
            string wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw  ";
            Assert.AreEqual(wait, res);
        }
    }
}
