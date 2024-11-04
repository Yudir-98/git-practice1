// 문자형 기본타입
// 1. char : 유니코드 16bit 문자열. (cf) 8bit(256개) ASCII코드)) 범위 : U+0000 ~ U+FFFF (16진수)
// 2. string : char의 조합. 문자열. ex) school

// boolean 기본타입
// 1. bool: true, false
using System.Text;

namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        char ch = 'A';
        string str1 = "A";
        string str2 = "school";

        Console.WriteLine(ch);
        Console.WriteLine(str1);
        Console.WriteLine(str2);

        char ch1 = '\t';    // tab문자 표현
        char ch2 = 'T';
        char ch3 = '\n';    // 개행(new Line)(한줄 띄우기) 문자를 표현
        char ch4 = 'o';

        Console.Write(ch1);
        Console.Write(ch2);
        Console.Write(ch3);
        Console.Write(ch4);

        Console.WriteLine();    // 한줄 띄우기

        char ch5 = '\u25b6';
        Console.WriteLine(ch5);

        string sp1 = "▶";
        Console.WriteLine(sp1);

        string sp2 = "Λ";
        Console.WriteLine(sp2);

        char ch6 = '\\';
        Console.WriteLine(ch6);     // '\'가 표시

        string str3 = "\\10,000";
        Console.WriteLine(str3);    // \10,000

        string str4 = "Hello, World";
        Console.WriteLine(str4);    // Hello, World

        string str5 = "\"Hello, World\"";
        Console.WriteLine(str5);    // "Hello, World"

        string str6 = "\tHello\tWorld";
        Console.WriteLine(str6);    //      Hello   World

        string str7 = @"\tHello\tWorld";
        Console.WriteLine(str7);    // \tHello\tWorld

        string str8 = "Hello";
        Console.WriteLine(str8 + " " + "World!");   // Hello World!

        // 정수형(8가지), 실수형(3가지), 문자열(2가지), 불린형(1가지)
        bool bl1 = true;    // bool은 true와 false만 가능
        Console.WriteLine("bl1의 값은 " + bl1);     // bl1의 값은 true

        string a = "10000";
        String b = "10000";
        String c = a + b;       // 1000010000

        int a1 = 10000;
        int b1 = 10000;
        int c1 = a1 + b1;       // 20000
    }
}