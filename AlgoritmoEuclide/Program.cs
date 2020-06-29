using System;

namespace AlgoritmoEuclide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write b");
            int b = Convert.ToInt32(Console.ReadLine());
            int mcd = FindMCD(a, b);
            Console.WriteLine($"MCD={mcd}");
            
        }

        public static int FindMCD(int a, int b)
        {
            if (a < b)
            {
                Change(ref a, ref b);
            }
            int r = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private static void Change(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
