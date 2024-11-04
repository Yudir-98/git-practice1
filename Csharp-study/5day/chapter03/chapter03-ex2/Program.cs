namespace ConsoleApp1;

class Project
{
    static void Main(string[] args)
    {
        string text1 = "안녕하세요";
        Console.WriteLine(text1);

        // for문으로 분한해서 출력(string 배열을 이용)
        for(int i = 0; i < text1.Length; i++) Console.Write(text1[i]);
        Console.WriteLine();

        // 문제: 문자열 뒤집기
        //   Q: 사용자로부터 문자열을 입력받아 그 문자열을 뒤집어서 출력하세요.
        //      단일 for문을 사용하세요.
        // 예시: 문자열을 입력하세요: 안녕하세요
        //       뒤집힌 문자열: 요세하녕안
        Console.Write("문자열을 입력하세요: ");
        string input = Console.ReadLine();
        Console.Write("뒤집힌 문자열: ");
        for (int i = 0; i < input.Length; i++) Console.Write(input[input.Length - 1 - i]);
    }
}