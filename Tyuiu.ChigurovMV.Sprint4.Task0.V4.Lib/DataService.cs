using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChigurovMV.Sprint4.Task0.V4.Lib
{
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int i, p;
            p = 1;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) p *= array[i];
            }
            return p;
        }
    }
}
