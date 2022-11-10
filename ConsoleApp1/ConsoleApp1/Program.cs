using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //n-ci fibonaci ededini hesablayan metod yazin
            //Console.WriteLine(Fibonaci(10));

            //FindIndex
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int result = FindIndex(array, 9);
            //if (result == -1)
            //{
            //    Console.WriteLine("NotFound");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}

            //CountOfNumbers
            //int[] array = { 1, 2, 3, -1, -2, 0, -10 };
            //CountOfNumbers(array);


            //Factorial
            Console.WriteLine(Factorial(3));


        }


        //static int Fibonaci(int n)
        //{
        //    int a = 0;
        //    int b = 1;
        //    int c = 0;
        //    for (int i = 3; i <= n; i++)
        //    {
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    return c;
        //}

        //static int FindIndex(int[] array, int num)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == num)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}


        //static void CountOfNumbers(int[] array)
        //{
        //    int countzero = 0;
        //    int positive = 0;
        //    int negative = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > 0)
        //        {
        //            positive++;
        //        }
        //        else if (array[i] == 0)
        //        {
        //            countzero++;
        //        }
        //        else
        //        {
        //            negative++;
        //        }
        //    }
        //    Console.WriteLine(countzero);
        //    Console.WriteLine(positive);
        //    Console.WriteLine(negative);
        //}


        static int Factorial(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
