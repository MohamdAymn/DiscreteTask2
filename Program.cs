using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1 = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            int n2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (i == sum)
                {
                    Console.Write(i + "\t");
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }

            }
        }
    }
}
