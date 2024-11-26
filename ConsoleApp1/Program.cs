using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 3, 8, 1, 2 };
            int[] array2 = { 7, 9, 2, 4 };

            Console.WriteLine("Массив по возрастанию:");
            SortArrayA(array1);
            PrintArray(array1);

            Console.WriteLine("Массив по убыванию:");
            SortArrayD(array1);
            PrintArray(array1);

            int[] combinedArray = Combin(array1, array2);
            Console.WriteLine("Объединённый массив:");
            PrintArray(combinedArray);

            Console.WriteLine("\nРасчет абсолютной разности:");
            Console.Write("Введите целое число n: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = AbsoluteD(n);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ввод некорректен. Пожалуйста, введите целое число.");
            }

            Console.Read();
        }

        static void SortArrayA(int[] array)
        {
            Array.Sort(array);
        }

        static void SortArrayD(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        static int[] Combin(int[] array1, int[] array2)
        {
            int[] combinedArray = new int[array1.Length + array2.Length];
            Array.Copy(array1, combinedArray, array1.Length);
            Array.Copy(array2, 0, combinedArray, array1.Length, array2.Length);
            return combinedArray;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static int AbsoluteD(int n)
        {
            int difference = Math.Abs(n - 123);
            if (n > 123) 
            {
                return difference * 3; 
            }
            else
            {
                return difference; 
            }
        }

    }
}
