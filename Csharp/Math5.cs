using System;
using System.IO;
using System.Text;

namespace Csharp_WorkSpace
{
    class Math5
    {
        static StreamReader input = new StreamReader(Console.OpenStandardInput());
        static void Main(string[] args)
        {
            int cnt = int.Parse(input.ReadLine());
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < cnt; i++)
            {
                String[] line = input.ReadLine().Split(" ");
                int h = int.Parse(line[0]);
                int w = int.Parse(line[1]);
                int n = int.Parse(line[2]);

                int remain = n%h; 
                output.Append(remain == 0 ? h : remain);
                int quot = n / h;
                quot = remain == 0 ? quot : quot + 1;
                if (quot < 10)
                {
                    output.Append("0");
                }
                output.Append(quot + "\n");
            }
            Console.Write(output);
        }
    }
}
