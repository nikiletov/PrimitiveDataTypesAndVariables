/*
Problem 1. Declare Variables/Declare five variables choosing for each of them the most appropriate of the types 
byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/
using System;
class declareVariables
{
    static void Main()
    {
        sbyte fusrtNumber = 97;
        sbyte secondNumber = -115;
        short thidrNumber = -10000;
        ushort fourthNumber = 52130;
        int fifthNumber = 4825932;
        Console.WriteLine("{0} , {1} , {2} , {3} , {4}", fusrtNumber, secondNumber, thidrNumber, fourthNumber, fifthNumber);
        Console.Read();
    }
}
