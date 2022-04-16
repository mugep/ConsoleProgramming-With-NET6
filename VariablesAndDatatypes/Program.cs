// See https://aka.ms/new-console-template for more information

//Variable Declarations and Types
string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

//Prompt User for Input
Console.WriteLine("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please Enter Your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please Enter Your Gender: ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are You Working: ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine("Your name is: " + fullName); //concatenation
Console.WriteLine("Your Age is: {0}", age);
Console.WriteLine($"Your Salary is: {salary}"); //interpolation
Console.WriteLine($"Your Gender is: {gender}"); //interpolation
Console.WriteLine($"Your are Employed: {working}"); //interpolation