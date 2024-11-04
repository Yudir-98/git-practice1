namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 문제2: 간단한 메뉴 선택
        //    Q.사용자에게 간단한 메뉴를 보여주고, Console.ReadKey()를 이용하여 메뉴를 선택하게 한 후 해당 동작을 수행하는 프로그램을 작성하세요.
        //메뉴:
        //  1. 프로그램 시작
        //  2. 설정 변경
        //  3. 프로그램 종료
        // 사용자가 숫자 키(1, 2, 3)를 누르면 각 동작에 맞는 메시지를 출력하세요.

        // 문제 2 ans_1
        Console.WriteLine("1. 프로그램 시작");
        Console.WriteLine("2. 설정 변경");
        Console.WriteLine("3. 프로그램 종료");

        ConsoleKeyInfo choice = Console.ReadKey();
        switch (choice.KeyChar)
        {
            case '1':
                Console.WriteLine("프로그램 시작");
                break;
            case '2':
                Console.WriteLine("설정 변경");
                break;
            case '3':
                Console.WriteLine("프로그램 종료");
                break;
        }

        // 문제 2 ans_1
        Console.WriteLine("1. 프로그램 시작");
        Console.WriteLine("2. 설정 변경");
        Console.WriteLine("3. 프로그램 종료");

        ConsoleKeyInfo choice2 = Console.ReadKey();
        if (choice2.KeyChar == '1') Console.WriteLine("프로그램 시작");
        if (choice2.KeyChar == '2') Console.WriteLine("설정 변경");
        if (choice2.KeyChar == '3') Console.WriteLine("프로그램 종료");
    }
}