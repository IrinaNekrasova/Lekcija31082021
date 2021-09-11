using System;

namespace My_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloText = "My name is Irina";
            int myNumber = 254;
            float myFloat = 13.54f;
            double myDouble = 14.5;
            bool isCool = true;
            char myLetter = 'D';

            Console.WriteLine(helloText);
            Console.WriteLine(myNumber);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(isCool);
            Console.WriteLine(myLetter);

            Console.WriteLine("____________________________________________________________________");

            int number1 = 2;
            int number2 = 5;
            int numSum2 = number1 + number2;
            Console.WriteLine(numSum2);

            int number3 = 10;
            int number4 = 3;
            int numSum3 = number3 / number4;
            Console.WriteLine(numSum3);

            double number5 = 10;
            int number6 = 3;
            double numSum4 = number5 / number6;
            Console.WriteLine(numSum4);

            Console.WriteLine( "____________________________________________________________________");

            bool isEquel = 15 == 17;
            Console.WriteLine(isEquel);

            bool isNotEquel = !isEquel;
            Console.WriteLine(isNotEquel);

            bool iamtrue = true;
            bool iamfalse = false;
            bool result1 = iamtrue && iamfalse;
            bool result2 = iamtrue|| iamfalse;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.WriteLine("____________________________________________________________________");

            int mynumber7 = 21;
            mynumber7 += 4;
            Console.Write(mynumber7);


            int mynumber8 = 21;
            mynumber8 -= 11;
            Console.Write(mynumber8);

            Console.WriteLine("____________________________________________________________________");

            Console.WriteLine("Ievadi savu vārdu!");
            string userAnswer = Console.ReadLine();
            Console.WriteLine("hello" + userAnswer);

            Console.WriteLine("Ievadi savu vecumu!");
            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);
            int fullAge = userAge + 100;

            Console.WriteLine("hello" + fullAge);

            Console.WriteLine("____________________________________________________________________");

            int maxNumber1 = 5;
            int maxNumber2 = 7;
            int maxLargest = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine(maxLargest);

            double numberToRound = 14.6789;
            double rounded = Math.Round(numberToRound, 2);
            Console.WriteLine(rounded);













        }
    }
}
