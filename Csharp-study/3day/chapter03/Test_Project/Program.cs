namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. 1번 줄은 65535이하 이면 true");
        Console.WriteLine("2. 2번 줄은 12000이상 이면 \"합격입니다.\" 출력. 아닐경우 \"탈락입니다.\" 출력");
        Console.WriteLine("3. 3번 줄은 22000이하 이면 3으로 나눈 나머지 값 출력 아닐 경우 5로 나눈 나머지 값 출력");


        ConsoleKeyInfo[,] Strings = new ConsoleKeyInfo[3, 5];

        Strings[0, 0] = Console.ReadKey();
        Strings[0, 1] = Console.ReadKey();
        Strings[0, 2] = Console.ReadKey();
        Strings[0, 3] = Console.ReadKey();
        Strings[0, 4] = Console.ReadKey();
        Console.WriteLine();

        Strings[1, 0] = Console.ReadKey();
        Strings[1, 1] = Console.ReadKey();
        Strings[1, 2] = Console.ReadKey();
        Strings[1, 3] = Console.ReadKey();
        Strings[1, 4] = Console.ReadKey();
        Console.WriteLine();

        Strings[2, 0] = Console.ReadKey();
        Strings[2, 1] = Console.ReadKey();
        Strings[2, 2] = Console.ReadKey();
        Strings[2, 3] = Console.ReadKey();
        Strings[2, 4] = Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine();
        string Line1 = Strings[0, 0].KeyChar.ToString() +
                       Strings[0, 1].KeyChar.ToString() +
                       Strings[0, 2].KeyChar.ToString() +
                       Strings[0, 3].KeyChar.ToString() +
                       Strings[0, 4].KeyChar.ToString();
        string Line2 = Strings[1, 0].KeyChar.ToString() +
                       Strings[1, 1].KeyChar.ToString() +
                       Strings[1, 2].KeyChar.ToString() +
                       Strings[1, 3].KeyChar.ToString() +
                       Strings[1, 4].KeyChar.ToString();
        string Line3 = Strings[2, 0].KeyChar.ToString() +
                       Strings[2, 1].KeyChar.ToString() +
                       Strings[2, 2].KeyChar.ToString() +
                       Strings[2, 3].KeyChar.ToString() +
                       Strings[2, 4].KeyChar.ToString();
        Console.WriteLine(Line1);
        Console.WriteLine(Line2);
        Console.WriteLine(Line3);
        Console.Write("1. ");
        Console.WriteLine(int.Parse(Line1) <= 65535);
        if (int.Parse(Line2) >= 12000) Console.WriteLine("2. \"합격입니다.\"");
        else Console.WriteLine("2. \"탈락입니다.\"");
        Console.Write("3. ");
        if (int.Parse(Line3) <= 22000) Console.WriteLine(int.Parse(Line3) % 3);
        else Console.WriteLine(int.Parse(Line3) % 5);
    }
}