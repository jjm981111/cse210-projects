using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        FileManager filemanager = new FileManager();
        while (true) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) {
               PromptGenerator question = new PromptGenerator();
               string prompt = question.RandomPrompt(); 

               Console.WriteLine(prompt);
               string answer = Console.ReadLine();

               Entry entry = new Entry(prompt, answer);
               journal.AddEntry(entry);
               }

            else if (choice == 2) {
                journal.DisplayEntries();
            }

            else if (choice == 3) {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal = filemanager.LoadJournal(filename);
            }

            else if (choice == 4) {
                Console. Write("What it the filename? ");
                string filename = Console.ReadLine();

                filemanager.SaveJournal(journal, filename);
            }

            else if (choice == 5) {
                break;
            }

            else {
                Console.WriteLine ("Wrong choice.");
            }


            
        }
    }
}

public class PromptGenerator{
    List<string> _prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"

    };

    public string RandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}

public class Journal {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry){
            _entries.Add(entry);
        }

        public void DisplayEntries() {
            
            foreach (Entry entry in _entries){
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._text}");
        }
    }
}

public class Entry {
        public string _text;

        public string _prompt;

        public string _date;

        public Entry(string prompt, string answer){
            DateTime theCurrentTime = DateTime.Now;
            _date = theCurrentTime.ToShortDateString();

            _text = answer;

            _prompt = prompt;


        }
    }

