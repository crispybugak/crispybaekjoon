using System;

class Program
{
    static void Main()
    {
        // 두 정수 A와 B 입력받기
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        // 조건에 따라 출력하기
        if (A > B)
        {
            Console.WriteLine(">");
        }
        else if (A < B)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("==");
        }
    }
}
