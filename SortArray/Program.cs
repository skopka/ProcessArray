using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.Test();
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
            finally
            {
                WriteLine($"Press any key for exit");
                ReadKey();
            }
        }

        private void Test()
        {
            int minValue = 14;
            int[] testArray = { 1, 17, 20, 15, 3, 2, 35, 21, 7, minValue };

            WriteLine($"Min value = {minValue}");
            PrintArray(testArray, "Source array:");

            int[] processedArray = ProcessArray(testArray, minValue);
            PrintArray(processedArray, "New array:");
        }

        private int[] ProcessArray(int[] sourceArray, int minValue)
        {
            var query = from item in sourceArray
                        where item > minValue
                        orderby item descending
                        select item;

            var result = query.ToArray();

            return result;
        }

        private void PrintArray<T>(T[] arr, string text)
        {
            WriteLine(text);

            for (int i = 0; i < arr.Length; i++)
                Write($"{arr[i]} ");

            WriteLine();
        }
    }
}
