// See https://aka.ms/new-console-template for more information

Person person = new();
string middleName = string.Empty;
Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Your Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Your Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary);

Console.WriteLine("Enter Your Middle Naame: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full Name is: " + person.getFullName());
} else
{
    Console.WriteLine("Full Name is: " + person.getFullName(middleName));
}

//Console.WriteLine("First Name is: " + person.FirstName);
//Console.WriteLine("Last Name is: " + person.LastName);
Console.WriteLine("Full Name is: " + person.getFullName());
Console.WriteLine("Age is: " + DateUtil.YearOfBirth(person.Age));
Console.WriteLine("Salary is: " + person.getSalary());

Console.WriteLine("Your Birth Year is " + person.getBirthOfYear());
//person.FirstName = "Muhamad";
//person.LastName = "Gerald";
//person.Age = 23;
//Console.WriteLine(person.LastName);
