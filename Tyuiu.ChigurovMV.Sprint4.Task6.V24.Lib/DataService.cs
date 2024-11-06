using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChigurovMV.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, w => w.Length > 7);
            return mas;
        }
    }
}
