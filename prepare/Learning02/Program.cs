using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job ("Programmer","Google",2025,2028);
        var job2 = new Job ("Software Engineer", "Amazon",2028,2040);
        var myname = new Resume("Jaemok Jo");

        myname.Displayname();
        Console.WriteLine("Jobs:");
        job1.Displayjob();
        job2.Displayjob();

        
    }
}

public class Job {

    public string _jobtitle;
    public string _company;
    public int _startyear;
    public int _endyear;

    public Job (string jt, string co, int sy, int ey) {
        _jobtitle = jt;
        _company = co;
        _startyear = sy;
        _endyear = ey;
    }

    public void Displayjob() {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startyear}-{_endyear}");
    }


}


public class Resume {
    public string name;

    public Resume (string nm) {
        name = nm;
    }

    public void Displayname(){
        Console.WriteLine ($"Name: {name}");
    }

}