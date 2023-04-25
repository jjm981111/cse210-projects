using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write ("What is your grade percentage? ");
        int gradeper = int.Parse(Console.ReadLine());

        if (gradeper>=70)
        {Console.WriteLine ("You passed it!!");

        if (gradeper>=90)
        {Console.WriteLine("Your grade is A");}
        else if (gradeper>=80)
        {Console.WriteLine("Your grade is B");}
        else if (gradeper>=70)
        {Console.WriteLine("Your grade is C");}
        else if (gradeper>=60)
        {Console.WriteLine("Your grade is D");}
        else
        {Console.WriteLine("Your grade is F");}

        }
        else
        {Console.WriteLine("Sorry, You should take this class again.");}
    }
}