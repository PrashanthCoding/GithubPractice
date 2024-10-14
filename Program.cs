
using System;

public class Class1
{
    public Class1()
    {
       // Ask the user to enter input values
        Console.WriteLine("Enter input values: "); 
        
        // Read the input string from the console
        var input = Console.ReadLine(); 
        
        // Initialize an empty string for storing the reversed version of the input
        var reverse = string.Empty; // Use "string.Empty" instead of "string.empty" (correct casing)

        int i = 0; // Initialize a counter variable i to 0

        // Loop through each character of the input until all characters are processed
        while (i < input.Length)
        {
            // Append each character from input[i] to the reverse string
            reverse = input[i] + reverse; // Prepending the character to reverse string to build it backwards
            
            // Increment i to move to the next character in the input
            i++; 
        }

        // Compare the original input with the reversed string
        if (input == reverse)
        {
            // If input and reverse are the same, it's a palindrome
            Console.WriteLine("The Input is a palindrome.");
        }
        else
        {
            // If input and reverse are different, it's not a palindrome
            Console.WriteLine("The Input is not a palindrome.");
        }

        // Print a new line after the output for better readability
        Console.WriteLine(); // Use "Console.WriteLine()" instead of "Console.writeLine()" (correct casing)
    }
}
