class Goal {
    protected bool _iscompleted;

    protected string _goal;

    protected string _description;

    protected int _point;

    protected string _sentence;

   
    public virtual string GetData() {
        return $"{_point}";
    }

    public bool GetComplete(){
        return _iscompleted;
    }

    

    public virtual string GoalSet(){
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public string GetGoal(){
        return _goal;
    }

    public virtual string DescriptionSet(){
        Console.Write("What is a short description of it? ");
         _description = Console.ReadLine();
        return _description;
    }

    public string Getdescription(){
        return _description;
    }

    public virtual int PointSet(){
        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }


    public string DisplayGoals(){
        if (_iscompleted == true) {
            return "[x]";
        }
        else{
            return "[ ]";
        }
    }

    public virtual int GetPoint(){
        return _point;
    }

    public virtual void SetCompleted(bool Iscompleted){
        _iscompleted = Iscompleted;
    }

   

    

    public virtual string Sentencemade(){
        return _sentence;
    }

    public virtual void SetLoad(string goal, string description, int point){
        _goal = goal;
        _description = description;
        _point = point;
    }



}

class Simple:Goal{
    
    public override string GoalSet(){
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string DescriptionSet(){
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }

    

    public override int PointSet(){
        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }

    public override string GetData()
    {
        return $"SimpleGoal:{_goal},{_description},{_point},{_iscompleted}";
    }
       public void SetLoad(string goal, string description, int point, bool iscompleted){
        _goal = goal;
        _description = description;
        _point = point;
        _iscompleted = iscompleted;
    }

}

class Eternal: Goal{

    public override string GoalSet(){
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string DescriptionSet(){
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }

    public override int PointSet(){
        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }
     public override string GetData()
    {
        return $"EternalGoal:{_goal},{_description},{_point}";
    }

     public override void SetLoad(string goal, string description, int point){
        _goal = goal;
        _description = description;
        _point = point;
    }

}

class Checklist:Goal{

    
    private int _timecompleted;
    private int _frequency;

    private int _bonus;


    public override string GoalSet(){
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string DescriptionSet(){
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }

    public override int PointSet(){
        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }

    public int Frequency() {
        Console.Write("How many times does this goal need to be accomplished to get a bonus? ");
        _frequency = int.Parse(Console.ReadLine());
        return _frequency;
    }

    

    public int Bonus(){
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        return _bonus;
    }

    public int GetBonus(){
        return _bonus;
    }

    public int timecompleted(){
        _timecompleted++;
        return _timecompleted;
    }

    public int Gettimecompleted(){
        return _timecompleted;
    }

     public override void SetCompleted(bool Iscompleted){
        _timecompleted++;
        if (_timecompleted == _frequency){
            _iscompleted = true;
        }
    }

      public override string GetData()
    {
        return $"ChecklistGoal:{_goal},{_description},{_point},{_bonus},{_frequency},{_timecompleted}";
    }

     public string GetSentence(){
        _sentence = $"-- Currently completed: {_timecompleted}/{_frequency}";
        return _sentence;
    }

    
    public override string Sentencemade(){
        return GetSentence();
    }

      public override int GetPoint(){
        if (_timecompleted == _frequency){
            return GetBonus()+_point;
        }
        else{
            return _point;
        }
    }

     public void SetLoad(string goal, string description, int point, int timecompleted, int frequency, int bonus){
        _goal = goal;
        _description = description;
        _point = point;
        _timecompleted = timecompleted;
        _frequency = frequency;
        _bonus = bonus;
    }

    public int GetFrequency(){
        return _frequency;
    }


  
}