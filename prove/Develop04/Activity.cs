class Activity{
    public void Ready(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void end(int seconds, string activity){
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {seconds} seconds of the {activity} Activity");
        ShowSpinner(5);
        Console.Clear();
    }
    public static void ShowSpinner(int duration) {

        List<string> animations = new List<string> {
            "-",
            "\\",
            "|",
            "/",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;
        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            Console.Write(frame);

            Thread.Sleep(250);

            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count) {
                animationIndex = 0;
            }
        }
    }
}

class Breath: Activity{
    public int _seconds;


    public Breath(int seconds){
        _seconds = seconds;
    }

    public void Breathe(){
        int duration =_seconds;
        int breatheInDuration = 4;
        int breatheOutDuration = 6;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (futureTime > DateTime.Now){
            Console.Write("Breath In..."); Countdown(breatheInDuration);
            Console.WriteLine();

            Console.Write("Breath out..."); Countdown(breatheOutDuration);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
     static void Countdown(int duration) {
        int currentValue = duration;

        while (currentValue>0){
            Console.Write(currentValue);
            Thread.Sleep(1000);
            currentValue--;Console.Write("\b \b");
        }
    }
}

class Reflection: Activity {
    public int _seconds;

    public Reflection (int seconds) {
        _seconds = seconds/2;
    }


    List<string> _prompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."

    };

    List<string> _questions = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
    };

     public string RandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public string RandomPrompt2(){
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    static void Countdown(int duration) {
        int currentValue = duration;

        while (currentValue>0){
            Console.Write(currentValue);
            Thread.Sleep(1000);
            currentValue--;Console.Write("\b \b");
        }
    }

    public void Begin() {
        Console.Write("You may begin in: "); Countdown(5);
    }

    public void Ask(){
        string question1 = RandomPrompt2();
        string question2;

    do
    {
        question2 = RandomPrompt2();
    } while (question2 == question1);
        Console.Write($"> {question1}" );ShowSpinner(_seconds);
        Console.WriteLine();
        
        Console.Write($"> {question2}" );ShowSpinner(_seconds);
        Console.WriteLine();
    }



}

class Listing:Activity {
    public int _seconds;

    public Listing(int seconds){
        _seconds = seconds;
    }

    List <string>  _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

     public string RandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public void ListItems(){
        int duration =_seconds;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        int count = 0;

        while (futureTime > DateTime.Now){
            Console.Write("> ");
            string list = Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
    
    }

    
    static void Countdown(int duration) {
        int currentValue = duration;

        while (currentValue>0){
            Console.Write(currentValue);
            Thread.Sleep(1000);
            currentValue--;Console.Write("\b \b");
        }
    }

    public void Begin() {
        Console.Write("You may begin in: "); Countdown(5);
        Console.WriteLine();
    }





}