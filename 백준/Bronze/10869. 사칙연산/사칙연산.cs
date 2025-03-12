namespace CS_250312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}