class goalManager{
    public void Savegoals(List<Goal> goals, int points, string filename) {

        using (StreamWriter outputFile = new StreamWriter(filename)) {
            outputFile.WriteLine(points);

            foreach (Goal goal in goals) {

                string data = goal.GetData();
                outputFile.WriteLine(data);
            }
        }
    }

    public (List<Goal>,int) Loadgoals(string filename) {

        string[] lines = System.IO.File.ReadAllLines(filename);
        int points = int.Parse(lines[0]);
        List<Goal> goals = new List<Goal>();

        for (int i = 1; i < lines.Length; i++) {

            string line = lines[i];

            string[] parts = line.Split(":");

            string goalType = parts[0];
            string[] parts2 = parts[1].Split(",");
            string name = parts2[0];
            string desc = parts2[1];
            int points1 = int.Parse(parts2[2]);

            if (goalType == "SimpleGoal") {
                bool complete = bool.Parse(parts2[3]);
                var goal = new Simple();
                goal.SetLoad(name, desc, points1,complete);
                goal.GetGoal();
                goal.Getdescription();
                goal.GetPoint();
                goal.GetComplete();
                goals.Add(goal);
            }
            else if (goalType == "EternalGoal"){
                var goal = new Eternal();
                goal.SetLoad(name, desc, points1);
                goal.GetGoal();
                goal.Getdescription();
                goal.GetPoint();
                goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal"){
                int bonus = int.Parse(parts2[3]);
                int frequency = int.Parse(parts2[4]);
                int timecompleted = int.Parse(parts2[5]);
                var goal = new Checklist();
                goal.SetLoad(name, desc, points1,timecompleted,frequency,bonus);
                goal.GetGoal();
                goal.Getdescription();
                goal.GetPoint();
                goal.GetFrequency();
                goal.GetBonus();
                goal.Gettimecompleted();
                goals.Add(goal);
            }
        }

        return (goals,points);
    }
}
