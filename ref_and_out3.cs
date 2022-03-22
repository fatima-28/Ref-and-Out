using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3. Qəbul etdiyi integer parametrə həmin parametrin dəyərinin
            //ən yaxın kökaltı dəyərini mənimsədən metod
            
            int num = 36;
            Square(ref num);
        }

       static void Square(ref int value)
        {
            value = 25;
            int square = 0;
            for (int i = 0; i*i <= value; i++)
            {
                square = i;
            }
            Console.WriteLine(square);
        }
    }
}