/*
Problem 2. Float or Double?
Which of the following values can be assigned to a variable of type float and which to a variable
of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them
to ensure no precision is lost.
*/
using System;
class floatOrDouble
{
    static void Main()
    {
        float furstNumber = 12.345f;
        double secondNumber = 34.567839023;
        double thirdNumber = 3456.091;
        double fourthNumber = 8923.1234857;
        Console.WriteLine("this is float type :\n{0}\nothers is double type: \n{1} \n{2} \n{3}", furstNumber, secondNumber, thirdNumber, fourthNumber);
        Console.Read();
    }
}
