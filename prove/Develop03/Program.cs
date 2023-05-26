using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference ("3","16","John");
        var sentence = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth on him should not perish, but have eternal life");
        Console.Write($"{reference._reference} {reference._chapter}:{reference._verse} ");
        sentence.Display();

        Console.WriteLine();

        Console.Write("Press enter to continue or type 'quit' to finish:");
        string answer = Console.ReadLine();
        while (true) {
            if (answer == "quit" || sentence.IsallHidden()) {
                break;
            }

            else{
                Word[] randomwords = sentence.PickRandom();
                foreach (Word word in randomwords) {
                    string text = word.GetText();
                }
                Console.Write($"{reference._reference} {reference._chapter}:{reference._verse} ");
                sentence.Display();

                Console.WriteLine();
            }
            
            Console.Write("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
        }

        Console.Write("Please type the scripture you just memorized to review: ");
        string useranswer = Console.ReadLine();

        Console.WriteLine("The correct answer is:");
        sentence.Display();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Your answer is:");
        Console.WriteLine(useranswer);
        

     
}
}