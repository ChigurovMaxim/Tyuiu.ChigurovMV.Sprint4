using Tyuiu.ChigurovMV.Sprint4.Task5.V1.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Чигуров М. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Чигуров Максим Владиславович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая заменяет положительные элементы двумерного  *");
            Console.WriteLine("* массива на 1.                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows, columns;
            Console.WriteLine("* Введите количество строк в матрице");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("* Введите количество столбцов в матрице");
            columns = int.Parse(Console.ReadLine());
            int i, j;
            int[,] matrix = new int[rows, columns];
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-9,9);
                }
            }
            Console.WriteLine("* Матрица: ");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            matrix = ds.Calculate(matrix);
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
