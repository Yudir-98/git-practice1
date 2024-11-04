﻿
// 3.1 기본 자료형
// 3.1.1 정수형 기본 타입(<-> 소수, 실수 , 허수(i))
//   ex) 1, -1, 2, etc... 0.0(정수X)  0(정수) <-> 0.0(실수)
//   1) sbyte -> signed(부호가있는(+,-) 8비트 정수) -> -128 ~ 127
//   2) byte -> unsigned(부호가 없는 8비트 정수) -> 0 ~ 255
//   3) short -> signed(부호가있는(+,-) 16비트 정수) -> -32,768 ~ 32,767
//   4) ushort -> unsigned(부호가 없는 16비트 정수) -> 0 ~ 65,535
//   5) int -> signed(부호가 있는(+,-) 32비트 정수) -> -2,147,483,648 ~ 2,147,483,647
//   6) uint -> unsigned(부호가 없는 32비트 정수) -> 0 ~ 4,294,967,295
//   7) long -> signed(부호가 있는(+,-) 64비트 정수) -> -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
//   8) ulong -> unsigned(부호가 없는 64비트 정수) -> 0 ~ 18,~~~~~~~
namespace ConsoleApp1;

class Program  // collapse(펼치다), uncollapse(접다)
{
    static void Main(String[] args)
    {
        // 자료형 변수명 = 값(value)
        int n;              // 32bit 정수형의 n이라는 변수명을 선언
        long sum;           // 64bit 정수형의 sum이라는 변수명을 선언

        int a = 1;         // 32bit 정수형의 a라는 변수명을 선언함과 동시에 10을 대입
        long b = 100;       // 64bit 정수형의 b라는 변수명을 선언함과 동시에 100을 대입

        int n1 = 50;        // 선언과 동시에 값을 부여함
        int n2;             // 선언만 함
        n2 = 100;           // 값은 나중에 부여함

        n = 5;
        sum = 50;

        sum = n1 + n2;      // 50 + 100이여서 sum애는 150. 이전에 sum의 50값은 지워짐
        sum = 14;           // 이전에 저장된 n1 + n2값이 지워지고 14라는 값이 저장

        Console.WriteLine(sum);

        // int,long등 기본타입에 대한 C#의 별칭(class)
        // int  -> System.int32
        // uint -> System.uint32
        // 사용예제
        System.Int32 c1 = 10; // int c1 = 50;
        System.Int32 c2;
        c2 = 100;

        System.Int32 sum2 = c1 + c2;
        Console.WriteLine(sum2); // 110
    }
}

