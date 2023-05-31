using System;

class Program
{
    static void Main(string[] args)
    {
     var personOne = new Person("luke skywalker");

     var byuiPerson = new BYUIPerson ("obi-wan", "1");

     var studentOne = new Student ()
    }

}


// Parent class
// Super class
class Person{
    private string _name;

    protected string _height;

    public Person(string name) {
        _name = name;
    }

}

class BYUIPerson: Person {
    private string _iNumber;

    public BYUIPerson (string name, string iNumber): base(name) {
        _iNumber = iNumber;
    }
}

// Sub class
// Child class
class Student: BYUIPerson {

    private string _major;

    public Student {string name, string iNumber, string major} base(name, iNumber) {
        _major = major;
    }
}

class Teacher: BYUIPerson {

    private string _department;

    public Teacher {}

}

