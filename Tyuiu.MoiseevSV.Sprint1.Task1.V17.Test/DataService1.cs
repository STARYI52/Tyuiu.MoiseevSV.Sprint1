using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoiseevSV.Sprint1.Task1.V17.Lib;


namespace Tyuiu.MoiseevSV.Sprint1.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(12, result);
        }
    }
}
