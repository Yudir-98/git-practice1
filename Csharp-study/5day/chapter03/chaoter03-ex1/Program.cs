namespace ConsoleApp1;

class Project
{
    static void Main(string[] args)
    {
        // 문제1: for문을 이용해서 1부터 n까지의 합을 구하기
        //    Q: 사용자로부터 양의 정수 n을 입력받고, 1부터 n까지의 합을 구하여 출력하세요.
        //       단일 for문을 사용하여 계산합니다.
        Console.WriteLine("n의 값을 입력하세요: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        // 코드작성
        for(int i =0; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        // 문제2. 구구단 출력 (5단만 출력)
        //   Q: 구구단 5단을 출력하는 프로그램을 작성하세요.
        //   단일 for문을 사용하여 구구단의 결과를 출력하세요.
        // 출력 예
        //  5 x 1 = 5
        //  5 x 2 = 10
        //  5 x 3 = 15
        //     ...
        //  5 x 9 = 45
        int number = 5;

        // 코드 작성
        for(int j = 1; j <= 9; j++) Console.WriteLine($"{number} x {j} = {number * j}");

        // 문제3: 배열의 요소 합 구하기
        //   Q: 아래 numbers배열의 모든 요소의 합을 구하여 출력
        //      단일 for문 사용
        int[] numbers = { 3, 5, 7, 9, 11, 13 };
        sum = 0;
        for(int k =0; k < numbers.Length; k++) sum += numbers[k];
        Console.WriteLine(sum);
    }
}