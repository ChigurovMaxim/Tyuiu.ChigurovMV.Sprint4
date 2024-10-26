using Tyuiu.ChigurovMV.Sprint4.Task2.V19.Lib;

namespace Tyuiu.ChigurovMV.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
            int waitres = 49;
            int res = ds.Calculate(nums);
            Assert.AreEqual(waitres, res);
        }
    }
}