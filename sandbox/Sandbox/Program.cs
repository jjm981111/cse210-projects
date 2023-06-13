using System;

class Program
{
    static void Main(string[] args)
    {

        var hourly = new HourlyEmployee(1000, "elon musk", 14);
        var salary = new SalaryEmployee(90000, "rovert oppenheimer", 14);

        var employees = new List<Employee> {hourly, salary};

        foreach (var employee in employees) {
            Console.WriteLine(employee._name);
            Console.WriteLine(employee.payPeriodWages());
        }
    }
}

class Employee {
    public string _name;

    protected int _payPeriodLength;

    public Employee(string name, int payPeriodLength) {
        _name = name;
        _payPeriodLength = payPeriodLength;
    }

    public virtual double payPeriodWages(){
        return 0;
    }
}

class HourlyEmployee:Employee{

    double _rate;

    public HourlyEmployee(double rate, string name, int payPeriodLength): base(name, payPeriodLength){
        _rate = rate;
    }

    public override double payPeriodWages() {
        return _rate * 8 * _payPeriodLength;
    }

}

class SalaryEmployee: Employee {

    double _annualRate;

    public SalaryEmployee(double annualRate, string name, int payPeriodLength): base(name, payPeriodLength){
        _annualRate = annualRate;
    }

    public override double payPeriodWages()
    {
        return (_payPeriodLength/365.0)* _annualRate;
    }

}

