using System.Numerics;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 예약어(preserved), 키워드(keyword) : C#에서 미리 사용하고 있는 단어
        int Main = 1;
        int main = 2;

        // int 1n;

        // null 키워드 사용하기
        string? text = null;        // 데이터 타입 제일 오른쪽에 '?' 표시를 넣으면 null 사용
        int? a1 = 1;
        a1 = null;
        text = "null";

        Console.WriteLine("a1 : " + a1);
        Console.WriteLine("text: " + text);

        string text1 = "";      // empty라고 부름. 이 상태도 1bit를 차지함 null과 다름.

        System.Int32 a2 = 1;

        // 데이터 타입의 기본값
        bool result;            // 변수 reslut에는 false값이 들어 있다. 단, 이렇게 쓰지는 말 것
        bool result1 = false;   // 암묵적 값은 현업에서 문제가 되기 떄문에 값을 지정해 주는게 맞음.
        Console.WriteLine("result: " + result1);

        //int n;                 // 변수 n에는 0값이 들어 있다.
        //string text2;           // 변수 text2에는 null 값이 들어있다.

        // 상수(변하지 않는 수 - const 키워드) : const가 붙은 변수명인 경우 값 수정시 error
        //  ex) 원의 넓이를 구할 때 파이(PI)=3.14
        const bool result2 = false;

        const double PI = 3.14;

        const int n1 = 10 + 10;
        int n = Math.Max(n1, 5);        // 20, 5 중에서 큰 것인 20지정

        // 연산자(+, -, *, /, %)
        // % : 나누었을 떄의 나머지
        int z1 = 3 % 2;
        Console.WriteLine("3 % 2의 나머지는 " + z1);

        int z2 = 4 % 2;
        Console.WriteLine("4 % 2의 나머지는 " + z2);

        int x1 = 3 / 2;
        Console.WriteLine("3 나누기 2의 값은 " + x1);     // 1
        double x2 = 3 / 2.0;    // 정수 / 정수 -> 정수, 실수 / 정수 -> 실수
        Console.WriteLine("3 나누기 2의 값은 " + x2);     // 1.5
        double x3 = 3 / (double)2;
        Console.WriteLine("3 나누기 2의 값은 " + x3);     // 1.5
    }
}