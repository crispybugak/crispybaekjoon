using System;

class Program
{
    static void Main()
    {
        // 현재 시각 입력
        string[] input = Console.ReadLine().Split();
        int hour = int.Parse(input[0]);
        int minute = int.Parse(input[1]);

        // 요리 시간 입력
        int cookingTime = int.Parse(Console.ReadLine());

        // 총 분 계산
        minute += cookingTime;
        hour += minute / 60;  // 60분이 넘으면 시간을 증가
        minute %= 60;         // 60분 단위로 나눈 나머지가 새로운 분

        // 24시간 형식 유지
        hour %= 24;

        // 결과 출력
        Console.WriteLine($"{hour} {minute}");
    }
}
