using System;

class Program
{
    static void Main(string[] args)
    {
        //object
        //instance
        var layne = new Person("Layne", "Moseley");
        var david = new Person("David", "Hasselhoff");

    

        layne.Talk();
        david.Talk();
    }
}


//classification
class Person {


    //attributes
    //properties
    string firstName;
    string lastName;

    //constructor
    public Person(string fn, string ln) {
        firstName = fn;
        lastName = ln;
    }

    // behaviors
    public void Breath() {
        Console.WriteLine("Breathing");
    }

    public void Walk(){
        Console.WriteLine("Walking");
    }

    public void Talk(){
        Console.WriteLine($"Hi! Myname is {FullName()}");
    }

    public string FullName() {
        return $"{firstName} {lastName}";
    }

}

