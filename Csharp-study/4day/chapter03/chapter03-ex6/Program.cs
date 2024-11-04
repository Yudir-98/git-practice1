using System;

namespace ConsoleApp1;

class Program
{
    // 문제: 로또 프로그램 만들기
    // 로또 프로그램의 조건
    //   (1) 1 ~ 45까지 랜덤한 숫자 6자리를 출력
    //   (2) 숫자 6개는 같은 숫자가 나올 수 없다.

    // 예시
    //   생성된 로또 번호: 5 6 7 19 44 1
    //   프로그램 종료
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] lottoNumbers = new int[6];

        // 코드작성(while문과 if문 break를 활용하여 작성)
        int i = 0;
        int j;
        bool hasNumber;
        int temp;

        while (i < lottoNumbers.Length)
        {
            lottoNumbers[i] = random.Next(1, 46);
            j = 0;
            hasNumber = false;

            while (j < i)
            {
                if (lottoNumbers[i] == lottoNumbers[j])
                {
                    hasNumber = true;
                    break;
                }
                j++;
            }

            if (!hasNumber)
            {        
                i++;
            }
        }

        i = 0;
        while (i < lottoNumbers.Length-1)
        {
            j = 0;
            while(j < lottoNumbers.Length - i - 1)
            {
                if (lottoNumbers[j] > lottoNumbers[j + 1])
                {
                    temp = lottoNumbers[j];
                    lottoNumbers[j] = lottoNumbers[j+1];
                    lottoNumbers[j + 1] = temp;
                }
                j++;
            }
            i++;
        }

        i = 0;
        while (i < lottoNumbers.Length)
        {
            Console.Write(lottoNumbers[i] + " ");
            i++;
        }

    }
}
