using Tyuiu.ChigurovMV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.ChigurovMV.Sprint4.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Чигуров М. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Чигуров Максим Владиславович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подсчитывает произведение четных элементов  *");
            Console.WriteLine("* массива                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int len, i, a;
            Console.WriteLine("* Введите длину массива: ");
            len = int.Parse(Console.ReadLine());
            int[] nums = new int[len];
            for (i = 0; i < len; i++)
            {
                
                do
                {
                    Console.WriteLine("* Введите " + i + " элемент массива от 3 до 8");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 3 || a > 8) Console.WriteLine("* Неверный ввод!");
                } while (a < 3 || a > 8);
                nums[i] = a;
            }
            Console.WriteLine("* Данный массив: ");;
            for (i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(nums));
        }
    }
}
