using Tyuiu.ChigurovMV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.ChigurovMV.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            int[] nums = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
            int waitres = 4608;
            int res = ds.Calculate(nums);
            Assert.AreEqual(waitres, res);
        }
    }
}