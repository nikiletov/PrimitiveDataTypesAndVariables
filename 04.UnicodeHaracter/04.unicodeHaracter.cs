/*
Problem 4. Unicode Character
Declare a character variable and assign it with the symbol that has Unicode code 42 
(decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42.
The output should be *.
*/
using System;
class unicodeHarecter
{
    static void Main()
    {
        int number42 = 42;
        char unicode42 = (char)number42;
        Console.WriteLine(unicode42);
        Console.Read();
    }
}

