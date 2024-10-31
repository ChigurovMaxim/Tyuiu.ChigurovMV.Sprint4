using Tyuiu.ChigurovMV.Sprint4.Task5.V1.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            int[,] array = { { -1, 2, 3 },
                             {4,-5,6 },
                             {7,-8,-9 } };
            int[,] waitArray = { {-1, 1, 1 },
                                 {1,-5,1 },
                                 {1,-8,-9 } };
            array = ds.Calculate(array);
            CollectionAssert.AreEqual(waitArray, array);
        }
    }
}