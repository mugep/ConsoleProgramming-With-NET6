// See https://aka.ms/new-console-template for more information
string firstName = "Muhamad";
string lastName = "Gerald";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(lastName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine(" My full name is " + lastName + " " + firstName);
Console.WriteLine($" My full name is {lastName}, {firstName}");
Console.WriteLine(" My full name is {0}, {1}", lastName, firstName);

// String length
int length = lastName.Length;
Console.WriteLine($"My name is {length} letters long");

// Replace string parts
string newName = lastName.Replace('G', 'J');
Console.WriteLine(newName);

string newName1 = lastName.Replace('e', ' ');
Console.WriteLine(newName1);


// Append to the other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"My full name is {fullName}");

//Split String
string[] splitName = fullName.Split('m');
for(int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string emptyString = ""; // string.empty
string whiteString = " ";

// Compare Strings
if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if(firstName == lastName)
{
    Console.WriteLine("Names are equal");
}

if( firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if(comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
} else
{
    Console.WriteLine("Names are not equal");
}
// Convert to String

string convertedString = string.Empty;
int number = 1234566;

convertedString = Convert.ToString(number);