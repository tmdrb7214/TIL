namespace New;
class Program
{
    static void Main(string[] args)
    {
        
        /*
         이름 , 나이 입력 후 출력
        Console.Write("이름 : ");
        string name = Console.ReadLine();
        Console.Write("나이 : ");
        string age = Console.ReadLine();
        Console.WriteLine("이름 : {0}  나이 : {1}", name, age);
        */

        /*
         두가지 숫자의 사칙연
         * Console.Write("두가지 숫자를 입력 해주세요 : ");

        string input = Console.ReadLine();    
        string[] numbers = input.Split(' ');  
        int num1 = int.Parse(numbers[0]);     
        int num2 = int.Parse(numbers[1]);     

        int sum = num1 + num2;
        int min = num1 - num2;
        int mup = num1 * num2;
        int div = num1 / num2;
        int rem = num1 % num2;

        Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, min);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, mup);
        Console.WriteLine("{0} / {1} = {2} 나머지 {3}", num1, num2, div, rem);*/

        /*
          섭씨온도의 화씨온도 변환
         * Console.Write("섭씨 온도를 입력 해주세요 : ");
        string c = Console.ReadLine();
        float numc = int.Parse(c);
        float d = numc * 9 / 5 + 32;

        Console.WriteLine("섭씨온도{0}를 화씨온도로 변환한 값 : {1}",c , d);*/



        Console.WriteLine("키와 몸무계를 입력해주세요. ");
        Console.Write("키 ");
        string cm = Console.ReadLine();

        Console.Write("몸무계 ");
        string kg = Console.ReadLine();

        float cm1 = float.Parse(cm);
        float kg1 = float.Parse(kg);

        float bmi = kg1 / ((cm1/100)  * (cm1/100));


        Console.Write("키{0} 몸무계 {1} 의 BMI 지수는 {2} 입니다",cm , kg , bmi);

    }
}

