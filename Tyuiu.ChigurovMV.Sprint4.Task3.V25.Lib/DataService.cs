using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChigurovMV.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int i, p;
            p = 1;
            for (i = 0; i < array.GetLength(0); i++)
            {
                p *= array[i, 3];
            }
            return p;
        }
    }
}
