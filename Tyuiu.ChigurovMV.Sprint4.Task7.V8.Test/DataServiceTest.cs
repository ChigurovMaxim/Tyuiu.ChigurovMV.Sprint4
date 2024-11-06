using Tyuiu.ChigurovMV.Sprint4.Task7.V8.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();
            int n, m;
            n = 3; m = 4;
            string value = "264795863157";
            int wait = 37;
            int res = ds.Calculate(n,m,value);
            Assert.AreEqual(wait, res);
        }
    }
}