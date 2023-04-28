using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUsername();
        int usernumber = PromptUsernum();

        int square = squarenumber(usernumber);
        displaymessage(username,square);


        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUsername(){
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUsernum(){
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int squarenumber(int number){
            int squarenum = number * number;

            return squarenum;
        }

        static void displaymessage(string name, int squarenum){
            Console.WriteLine($"{name}, the square of your number is {squarenum}");
        }
    }
}