using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicnumber = generator.Next(1, 101);

        int userguess = -1;

        while (userguess != magicnumber) {

            Console.Write ("What is your guess? ");
            userguess = int.Parse(Console.ReadLine());

            if (userguess > magicnumber){
                Console.WriteLine ("LOWER");
            }

            else if (userguess < magicnumber){
                Console.WriteLine("HIGHER");
            }


        }
        Console.WriteLine ("YAY");
    }
}