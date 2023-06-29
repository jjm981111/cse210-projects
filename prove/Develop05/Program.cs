using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        int point1 = 0;
        int goalcount = 0;

        List<Goal> goals = new List<Goal>();
        goalManager goalmanager = new goalManager();

        while (true) {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Events");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalchoice = int.Parse(Console.ReadLine());
                if (goalchoice == 1){
                    var simpleanswers = new Simple();
                    simpleanswers.GoalSet();
                    simpleanswers.DescriptionSet();
                    simpleanswers.PointSet();
                    goals.Add(simpleanswers);
                    goalcount++;
                }
                else if (goalchoice == 2){
                    var eternalanswers = new Eternal();
                    eternalanswers.GoalSet();
                    eternalanswers.DescriptionSet();
                    eternalanswers.PointSet();
                    goals.Add(eternalanswers);
                    goalcount++;
                }
                else if (goalchoice ==3){
                    var checklistanswers = new Checklist();
                    checklistanswers.GoalSet();
                    checklistanswers.DescriptionSet();
                    checklistanswers.PointSet();
                    checklistanswers.Frequency();
                    checklistanswers.Bonus();
                    checklistanswers.Gettimecompleted();
                    checklistanswers.GetSentence();
                    goals.Add(checklistanswers);
                    goalcount++;
                }
            }

            else if (choice == 2){
                Console.WriteLine("The goals are:");
                for(int i = 0; i<goals.Count; i++){
                    Goal element = goals[i];
                    string goal = element.GetGoal();
                    string des = element.Getdescription();
                    string complete = element.DisplayGoals();
                    string sentence = element.Sentencemade();
                    Console.WriteLine($"{i+1}. {complete} {goal} ({des}) {sentence}");           
            }
            }

            else if (choice == 3){
                 Console. Write("What is the filename? ");
                string filename = Console.ReadLine();

                goalmanager.Savegoals(goals, points, filename);
            }

            else if (choice == 4){
                 Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                (List<Goal> loadedGoals, int loadedPoints) = goalmanager.Loadgoals(filename);
                goals = loadedGoals;
                points = loadedPoints;
            }
            

            else if (choice == 5){
                 Console.WriteLine("The goals are:");
                 for(int i = 0; i<goals.Count; i++){
                    Goal element = goals[i];
                    string goal = element.GetGoal();
                    Console.WriteLine($"{i+1}. {goal}");
                 }
                Console.Write("Which goal did you accomplish? ");
                var input = int.Parse(Console.ReadLine());
                var goalToComplete = goals[input-1];
                goalToComplete.SetCompleted(true);

                
                point1 = goalToComplete.GetPoint();
                points += point1;
                Console.WriteLine($"Congratulations! You have earned {point1} points!");
                Console.WriteLine($"You now have {points}.");
                Console.WriteLine();         
    }
         else if (choice == 6){
            Console.WriteLine($"You have made {goalcount} goals this time.");
            break;
         }
}
}
}


