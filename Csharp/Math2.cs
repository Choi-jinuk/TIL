using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 1;//몇개의 방을 지나가야 되는지에 대한 변수
            int power = 0;//값 비교를 위해 곱해줄 수
            while((n - (6*power + 1)) > 0 )
            {
                power = power + cnt++;
            }
            Console.Write(cnt);
        }
    }
}
