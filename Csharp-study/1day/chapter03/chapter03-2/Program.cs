// 실수형 기본타입
// 1) float -> 4byte(2의 32승)
// 2) double -> 8byte(2의64승)
// 3) decimal -> 16byte(2의 128승)

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        float f = 5.2f;      // 기본적으로 소수점은 double -> float으로 바꾸려면 숫자 마지막 뒤에 'f'를 넣어야 함
        double d = 10.5;
        decimal money = 200.099m;

        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(money);

        // 문제1. 다음과 같은 변수를 선언하고 올바르게 초기화하시오.
        //  (1) 정수형 변수 age애 25 할당하고 출력하는 코드작성
        //  (2) 소수점 값을 가지는 height변수에 175.5할당

        // 문제2. 아래 코드에서 오류를 찾아 수정하시오.
        /*
        byte num = 300;
        int result = num + 100.5;
         */

        // 1.(1)
        byte age = 25;
        // 1.(2)
        double height = 175.5;
        // float height = 175.5f;가 더 낫다. 데이터용량 때문에

        // 2.
        short num = 300;
        double result = num + 100.5;
    }
}
