using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChigurovMV.Sprint4.Task2.V19.Lib
{
    public class DataService : ISprint4Task2V19
    {
        public int Calculate(int[] array)
        {
            int i, s;
            s = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) s += array[i];
            }
            return s;
        }
    }
}
