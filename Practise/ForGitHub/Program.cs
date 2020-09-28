using System;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter the size of array :- ");

            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            
            Console.Write("Enter The Array :- ");

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(a);

            Console.WriteLine("Reverced Array :- ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}",a[i]);
            }

            Console.WriteLine("First Element of array is {0}",a[0]);
            Console.WriteLine("Last Element of array is {0}",a[n-1]);

            
        }
    }
}
