using System;

class Program
{
    static void Main(string[] args)
    {int breathcount = 0;
     int reflectcount = 0;
     int listcount = 0;
    while(true){
            Console.WriteLine("Menu options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
    
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
    
         if (choice == 1) {
            Console.WriteLine("Welcome to the Breating Activity.");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            int seconds = int.Parse(Console.ReadLine());
            var breath = new Breath(seconds);
            breath.Ready();
            breath.Breathe();
            breath.end(seconds, "Breathing");
            breathcount++;
         }

         else if (choice == 2) {
            Console.Clear();
            Console.WriteLine("Welcome to the Reflecting Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            int seconds = int.Parse(Console.ReadLine());
            var active = new Reflection(seconds);
            string prompt = active.RandomPrompt();

            active.Ready();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($" --- {prompt} ---");
            Console.WriteLine();
            Console.Write("When you have something in mind, press enter to continue.");
            string enter = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            active.Begin();
            Console.Clear();

            active.Ask();
            active.end(seconds, "Reflecting");
            reflectcount++;
         }

         else if (choice == 3) {
            Console.Clear();
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            int seconds = int.Parse(Console.ReadLine());
            var listing = new Listing(seconds);
            listing.Ready();
            Console.WriteLine("List as many responses you can to the following prompt:");
            string listprompt = listing.RandomPrompt();
            Console.WriteLine($" --- {listprompt} ---");
            listing.Begin();
            listing.ListItems();
            listing.end(seconds,"Listing");
            listcount++;

         }

         else if (choice ==4) {
            Console.WriteLine($"You have done Breathing Activity {breathcount} times");
            Console.WriteLine($"You have done Reflecting Activity {reflectcount} times");
            Console.WriteLine($"You have done listing Activity {listcount} times");
            break;
         }
         
    }


   
}
}