namespace ConsoleApp1;

class Project
{
    static void Main(string[] args)
    {
        // 복합 대입 연산자(+=. -=, *=, /=, %=)
        int n = 50;
        n += 5;     // n = n + 5;   // 55
        Console.WriteLine(n);

        n = 50;
        n -= 5;     // n = n - 5;   // 45
        Console.WriteLine(n);

        n = 50;
        n *= 5;     // n = n * 5;   // 250
        Console.WriteLine(n);

        n = 50;
        n /= 5;     // n = n / 5;   // 10
        Console.WriteLine(n);

        n = 50;
        n %= 5;     // n = n % 5;   // 0
        Console.WriteLine(n);

    }
}