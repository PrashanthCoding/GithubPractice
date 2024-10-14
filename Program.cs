using System;

public class Class1
{
    public Class1()
    {
        Console.WriteLine("Enter a input values: ");
        var input = Console.ReadLine();
        var reverse = "";
        int i = input.Length -1;
        
        while(i >=0)
        {
            reverse += input[i];
            i--;
        }

        if(input == reverse)
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
