using Tyuiu.ChigurovMV.Sprint4.Task6.V24.Lib;
namespace Tyuiu.ChigurovMV.Sprint4.Task6.V24
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
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Чигуров Максим Владиславович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Компьютер\", \"Телефон\", \"Планшет\",   *");
            Console.WriteLine("* \"Принтер\", \"Сканер\", \"Монитор\", \"Клавиатура\"], используя        *");
            Console.WriteLine("* класс Array, выведите элементы массива, длина которых больше 7 символов *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] stringWords = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            Console.WriteLine("Исходный массив: ");
            stringWords.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            ds.Calculate(stringWords).ToList().ForEach(Console.WriteLine);
        }
    }
}
