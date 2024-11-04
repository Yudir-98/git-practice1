namespace ConsoleApp1;

class Project
{
    static void Main(string[] args)
    {
        // 중첩 루프(다중 for문)
        for (int i = 0; i < 3; i++)
        {
            Console.Write("i:" + i + " -> ");   // 0 -> 
            Console.Write("j: ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(j + " "); // 0 1 2 
            }
            Console.WriteLine();
        }

        // 구구단
        for (int x = 2; x < 10; x++)
        {
            for (int y = 1; y < 10; y++)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
            Console.WriteLine();
        }

        // 구구단 2
        for (int x = 1; x < 10; x++)
        {
            for (int y = 2; y < 10; y++)
            {
                Console.Write($"{y} * {x} = {x * y}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        // 덧셈
        for (int x = 1; x < 10; x++)
        {
            for (int y = 1; y < 10; y++)
            {
                Console.Write($"{x} + {y} = {x + y}\t");
            }
            Console.WriteLine();
        }

        // 정사각형 별 패턴
        //   Q. 사용자가 입력한 숫자 n을 기준으로 n x n 정사각형의 별 패턴을 출력하세요.
        //      이중 for문을 사용하여 별을 출력하세요.
        // 예시: 정사각형의 크기를 입력하세요: 4
        // ****
        // ****
        // ****
        // ****

        Console.Write("정사각형의 크기를 입력하세요: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        // 별패턴 2
        Console.Write("직각삼각형의 크기를 입력하세요: ");
        int n2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n2; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        // 별패턴 3
        Console.Write("좌우로 뒤집힌 직각삼각형의 크기를 입력하세요: ");
        int n3 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n3; i++)
        {
            for (int j = 0; j <= n3 - i - 1; j++)
            {
                Console.Write(' ');
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        // 별패턴 4
        Console.Write("피라미드의 높이를 입력하세요: ");
        int n4 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n4; i++)
        {
            for (int j = 0; j <= n4 - i - 1; j++)
            {
                Console.Write(' ');
            }
            for (int k = 0; k <= 2 * i; k++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        // 별패턴 5
        Console.Write("다이아의 숫자를 입력하세요: ");
        int n5 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n5; i++)
        {
            for (int j = 0; j <= n5 - i - 1; j++)
            {
                Console.Write(' ');
            }
            for (int k = 0; k <= 2 * i; k++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n5 - 1; i++)
        {
            for (int j = 0; j <= i+1; j++)
            {
                Console.Write(' ');
            }
            for (int k = 1; k <= 2 * (n5 - 1 - i) - 1; k++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}