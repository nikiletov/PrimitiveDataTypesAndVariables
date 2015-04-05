/*
Problem 5. Boolean Variable
Declare a Boolean variable called is Female and 
assign an appropriate value corresponding to your gender.
Print it on the console.
*/
using System;
class BoolienVariable
{
    static void Main()
    {
        Console.WriteLine("You are male or female?");// i am man :))
        string gender = Console.ReadLine();
        bool isMale = gender == "male";
        Console.WriteLine("{0}", isMale);
        Console.Read();
    }
}
