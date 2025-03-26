using System;

class Program
{
    static void Main()
    {
        // 주사위 입력 받기
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int prize = 0;

        if (a == b && b == c) // 3개가 같을 때
        {
            prize = 10000 + a * 1000;
        }
        else if (a == b || a == c) // 2개가 같을 때 (a와 b 또는 a와 c가 같음)
        {
            prize = 1000 + a * 100;
        }
        else if (b == c) // 2개가 같을 때 (b와 c가 같음)
        {
            prize = 1000 + b * 100;
        }
        else // 모두 다를 때
        {
            prize = Math.Max(a, Math.Max(b, c)) * 100;
        }

        // 결과 출력
        Console.WriteLine(prize);
    }
}
