// See https://aka.ms/new-console-template for more information
// primitive datatypes
// int, string, char, bool

// Object Oriented Programming - Creating your own datatype
// class - blueprint

// Single responsibility Principle

public class Person
{
    // Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Fields
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
     }

    public double getSalary()
    {
        return _salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }
    
    public int getBirthOfYear ()
    {
        return DateTime.Now.Year - Age;
    }

    public string getFullName(string middlename)
    {
        return $"{FirstName} {middlename} {LastName}";
    }
}