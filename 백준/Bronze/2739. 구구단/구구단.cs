using System;

class Program
{
    static void Main()
    {
        // 숫자 N 입력 받기
        int N = int.Parse(Console.ReadLine());

        // 구구단 출력
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{N} * {i} = {N * i}");
        }
    }
}
