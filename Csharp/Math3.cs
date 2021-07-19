using System;

namespace Csharp_WorkSpace
{
    class Math3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = SearchLine(ref n); //몇번째 라인인지 구하기

            Console.WriteLine(Solve(n, cnt)); //결과 출력

        }
        static int SearchLine(ref int n)
        {
            int cnt = 1;//몇번째 라인인지
            int power = 1;//일정하게 더해진 수

            while ((n - power) > 0)
            {
                cnt++;
                power += cnt;
            }

            n -= power;//나머지 수를 구하기 위해 연산처리

            return cnt;
        }
        static string Solve(int _n, int _cnt)
        {
            int deno;//분모(denominator)
            int num;//분자(numerator)
            if (_cnt % 2 == 0) //라인수가 짝수인지 홀수인지
            {//짝수의 경우 분모에서 수가 시작
                num = _cnt; deno = 1;
                deno -= _n;
                num += _n;
            }
            else
            {//홀수의 경우 분자에서 수가 시작
                num = 1; deno = _cnt;
                num -= _n;
                deno += _n;
            }

            return num + "/" + deno;
        }
    }
}
