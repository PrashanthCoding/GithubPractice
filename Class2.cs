using System; // Importing the System namespace to use console input/output.

public class Class1 // Declaring a class named 'Class1'.
{
    public Class1() // Constructor for the 'Class1' class.
    {
        int i; // Declaring an integer variable 'i'.

        Console.Write("Enter a Number : "); // Asking the user to enter a number via console output.

        i = int.Parse(Console.ReadLine()); // Reading the user's input from the console and converting it to an integer.

        if (i % 2 == 0) // Checking if the entered number is divisible by 2 (i.e., even number).
        {
            Console.Write("Entered Number is an Even Number"); // Outputting a message to indicate that the number is even.
            Console.Read(); // Waiting for the user to press a key before closing the console.
        }
        else // If the number is not divisible by 2 (i.e., odd number).
        {
            Console.Write("Entered Number is an Odd Number"); // Outputting a message to indicate that the number is odd.
            Console.Read(); // Waiting for the user to press a key before closing the console.
        }
    }
}
