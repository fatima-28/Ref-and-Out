using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1. Parameter olaraq integer array variable-i ve bir integer value
            //qebul eden ve hemin integer
            //value-nu integer array-e yeni element kimi elave eden metod.

            int value = 8;
            Console.WriteLine(Array(ref value));
        }


        static int[] Array(ref int value)
        {
            int[] arr = { 1, 2, 5 };
            int[] newarr = arr;
            value = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if (i >= arr.Length)
                {
                    Console.WriteLine(arr[i]);
                }
                newarr = arr;

            }
            return newarr;

        }
    }
}