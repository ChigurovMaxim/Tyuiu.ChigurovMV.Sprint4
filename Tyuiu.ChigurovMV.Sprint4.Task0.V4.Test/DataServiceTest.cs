using Tyuiu.ChigurovMV.Sprint4.Task0.V4.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultEvenArrElTest()
        {
            DataService ds = new DataService();
            int[] nums = new int[10] { 1, 2, 3, 1, 1, 3, 2, 1, 1, 3 };
            int waitres = 4;
            int res = ds.GetMultEvenArrEl(nums);
            Assert.AreEqual(waitres, res);
        }
    }
}