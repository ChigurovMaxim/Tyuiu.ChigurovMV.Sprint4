using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChigurovMV.Sprint4.Task5.V1.Lib
{
    public class DataService : ISprint4Task5V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int i, j;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
