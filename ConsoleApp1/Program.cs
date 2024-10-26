namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {7,1,4,3,8,3};
            int p = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    p *= array[i];
                
            }
            Console.WriteLine(p);
        }
    }
}
