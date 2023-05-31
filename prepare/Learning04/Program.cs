using System;

class Program
{
    static void Main(string[] args)
    {
        var homework = new Assignment("Samuel Bennett", "Multiplication");
        var name = homework.Getsummary();
        Console.WriteLine(name);
        Console.WriteLine();

        var math = new MathAssignment("Roberto Rodriguez", "Fractions","7.3","8-19");
        var mathname = math.Getsummary();
        var mathlist = math.GetHomeworklist();
        Console.WriteLine(mathname);
        Console.WriteLine(mathlist);
        Console.WriteLine();

        var writing = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        var writingname = writing.Getsummary();
        var writingtopic = writing.GetWritingHomework();
        Console.WriteLine(writingname);
        Console.WriteLine(writingtopic);


    }
}

class Assignment {
    private string _name;

    private string _topic;

    public Assignment (string name, string topic){
        _name = name;

        _topic = topic;
    }

    public string Getname(){
        return _name;
    }
    public string Gettopic(){
        return _topic;
    }

    public string Getsummary(){
        return $"{_name} - {_topic}";
    }
}

class MathAssignment: Assignment {
    private string _section;

    private string _problems;

    public MathAssignment (string name, string topic, string section, string problems): base (name, topic){
        _section = section;

        _problems = problems;
    }

    public string GetHomeworklist (){
        return $"Section {_section} Problems {_problems}";
    }
}

class WritingAssignment : Assignment {
    private string _title;

    public WritingAssignment (string name, string topic, string title): base(name, topic) {
        _title = title;
    }

    public string GetWritingHomework(){
        string studentname = Getname();
        return $"{_title} by {studentname}";
    }
}