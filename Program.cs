
using System;

public class Class1
{
    public Class1()
    {
        Console.WriteLine("Enter a input values: ");
        var input = Console.ReadLine();
        var reverse = string.empty;

        int i = 0; // Start from the first character
        
        while (i < input.Length) // Loop through each character
        {
            reverse = reverse + input[i];// Prepend character to reverse string
            i++;// Increment i
        }

        // Check if input is equal to the reversed string
        if (input == reverse)
        {
            Console.WriteLine("The Input is a  palindrome.");
        }
        else
        {
            Console.WriteLine("The Input is not palindrome.");
        }

        Console.writeLine();
    }
}
