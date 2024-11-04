namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string productName1 = "";
        string productName2 = "";
        string productName3 = "";

        int priceProduct1 = 5000;
        int priceProduct2 = 5500;
        int priceProduct3 = 6000;
        int priceProduct4 = 10000;

        // 배열(array)
        int[] productPrices = new int[4];
        string[] productNames = new string[4];

        // 배열 start number는 0부터
        productPrices[0] = 5000;
        productPrices[1] = 5500;
        productPrices[2] = 6000;
        productPrices[3] = 10000;
        //productPrices[4] = 12000;     // runtime 에러(실행중에 에러가 발생) -> 0에서 3번까지만 허용

        int i = 0;
        productPrices[i] = 5200;

        Console.WriteLine(productPrices[0]);        // 5200

        int book = productPrices[1] + productPrices[2]; // 5500 + 6000 = 11500
        Console.WriteLine(book);    // 11500

        // 배열 선언 및 초기화
        int[] products = new int[5] { 1, 2, 3, 4, 5 };
        int[] products2 = { 1, 2, 3, 4, 5 };

        Console.WriteLine(products[0]);     // 1
        Console.WriteLine(products[1]);     // 2
        Console.WriteLine(products2[0]);    // 1

        // 문자열에 대한 배열
        string text = "Hello,World";
        char ch1 = text[0];     // H
        char ch2 = text[1];     // e
        char ch11 = text[10];   // d
        // char ch12 = text[11];// error -> text변수 문자열 11개까지(0~10)만 저장이 되어 있음;

        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        Console.WriteLine(ch11);

        // 배열의 기본값(int, float의 경우 0, string은 null)
        int[] students = new int[60];
        Console.WriteLine(students[0]); // 출력 결과 : 0
        float[] sosu = new float[60];
        Console.WriteLine(sosu[0]);     // 출력 결과 : 0

        // 다차원배열
        // 2차원배열
        int[,] arr2 = new int[60,60];   // 60 * 60 int공간을 가진 2차원 배열
        int[,,] arr3 = new int[60, 60, 60];   // 60 * 60 * 60 int공간을 가진 3차원 배열

        int[,] arr4 = new int[7, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12},
            {13, 14, 15},
            {16, 17, 18},
            {19, 20, 21}
        };
        Console.WriteLine(arr4[0, 1]);
        Console.WriteLine(arr4[1, 0]);
        Console.WriteLine(arr4[2, 1]);

        // 가변 배열(배열의 배열)
        int[][] arr5 = new int[5][];    // 5개의 열을 가진 가변 배열
        arr5[0] = new int[10];          // 0번째 index의 10개의 열을 가진 배열
        arr5[1] = new int[9];           // 1번째 index의 9개의 열을 가진 배열

        // 문제1: 아래 코드 arr6의 평균값을 출력하는 코드를 작성해 보세요.(소수점까지 표시)
        int[] arr6 = { 1, 2, 3, 4, 5, 6 };
        double avg = (arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6.0;
        Console.WriteLine(avg);
    }
}