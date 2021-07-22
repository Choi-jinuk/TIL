using System;
using System.IO;

namespace Csharp_WorkSpace
{
    class Math4
    {
        static StreamReader input = new StreamReader(Console.OpenStandardInput());
        static void Main(string[] args)
        {
            String[] line = input.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int v = int.Parse(line[2]);

            int day = ((v-a)/(a-b)) + 1;
            if((v-a)%(a-b) > 0) day++;

            Console.Write(day);
        }
    }
}
