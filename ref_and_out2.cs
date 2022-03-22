using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri
            //icində
            //bosluqlar qalmayacaq hala gətirən metod.
            
            string name;
            Spaceless(out name);
        }

        static void Spaceless(out string All)
        {
            string Space = " ";
            All = "Fatime Bayramova";
            for (int i = 0; i < All.Length; i++)
            {
                if (All[i] == Space[0])
                {
                    Console.Write(All[i + 1]);
                    i++;
                }
                else
                {

                    Console.Write(All[i]);
                }

            }

        }
    }
}
