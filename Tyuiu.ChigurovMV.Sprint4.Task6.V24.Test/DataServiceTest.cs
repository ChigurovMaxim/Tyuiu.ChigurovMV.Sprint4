using Tyuiu.ChigurovMV.Sprint4.Task6.V24.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();
            string[] stringWords = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] waitArray = { "Компьютер", "Клавиатура" };
            stringWords = ds.Calculate(stringWords);
            CollectionAssert.AreEqual(waitArray,stringWords);
        }
    }
}