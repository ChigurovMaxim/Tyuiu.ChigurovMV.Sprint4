using Tyuiu.ChigurovMV.Sprint4.Task4.V16.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Чигуров М. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Чигуров Максим Владиславович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая заменяет четные элементы двумерного массива *");
            Console.WriteLine("* на 1.                                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows, columns;
            Console.WriteLine("* Введите количество строк: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("* Введите количество столбцов: ");
            columns = int.Parse(Console.ReadLine());
            int i, j;
            int[,] array = new int[rows, columns];
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.WriteLine($"* Введите {i},{j} элемент массива");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("* Массив: ");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i,j]} \t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for ( i  = 0; i < rows; i++ )
            {
                for (j = 0; j < columns ; j++)
                {
                    Console.Write($"{ds.Calculate(array)[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
