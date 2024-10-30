using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChigurovMV.Sprint4.Task4.V16.Lib
{
    public class DataService : ISprint4Task4V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int i, j;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0;  j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                        
                }
            }
            return matrix;
        }
    }
}
