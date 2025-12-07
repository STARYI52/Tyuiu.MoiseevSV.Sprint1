using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MoiseevSV.Sprint1.Task0.V18.Lib;

namespace Tyuiu.MoiseevSV.Sprint1.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}