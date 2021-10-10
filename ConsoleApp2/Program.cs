using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("random array");

            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(0, 10);
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine();
            Array.Sort(arr);

            Console.WriteLine("sorted array");
            foreach (int number in arr)
            {
                Console.Write($"{number} \t");
            }

            Console.WriteLine();
            Array.Reverse(arr);

            Console.WriteLine("array without 0");
            foreach (int number in arr)
            {
                if (number == 0) Console.Write($"-1 \t");
                if (number != 0) Console.Write($"{number} \t");
            }

            Console.WriteLine();
            Console.WriteLine("enter any num  from 0 to 10 => ");
            string num = Console.ReadLine();
            int count = 0;

            foreach (int number in arr)
            {
                if (number == Convert.ToInt32(num)) count ++;
            }
            Console.WriteLine("The number " + num + " in array is " + count + " times");
            Console.WriteLine();


            Console.WriteLine("Random array: ");
            int n = 4;
            int m = 5;
            int[,] a = new int[m, n];
            n = rand.Next(0, 10);
            m = rand.Next(0, 10);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = rand.Next(10);
                    }
                }


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write("Change First and Last cols: ");
            int tmp;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                tmp = a[i, 0];
                a[i, 0] = a[i, a.GetLength(1) - 1];
                a[i, a.GetLength(1) - 1] = tmp;
                
            }

            Console.WriteLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    
    }




}
