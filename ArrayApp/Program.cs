using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int num = int.Parse(Console.ReadLine());
            int[] a = new int[num];
            Console.WriteLine("Введите элементы");
            for (int i = 0; i < num; i++) 
            {
                Console.Write("array[{0}] = ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Элементы в обратном порядке");
            for (int i = num - 1; i >= 0; i--) {
                Console.WriteLine(a[i]);
            }
        }
    }
}
