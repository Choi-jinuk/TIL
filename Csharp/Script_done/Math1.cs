using System;

namespace Csharp
{
    class Math1
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int profit = c - b;

            if( profit <= 0 )
            {
                Console.Write("-1");
            }
            else
            {
                Console.Write(a/profit + 1);
            }
        }
    }
}
