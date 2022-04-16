// See https://aka.ms/new-console-template for more information

// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1998, 10, 21);
Console.WriteLine("My Dob is: " + dateOfBirth);
Console.WriteLine("My Dob is: " + dateOfBirth.Date);

// Create a Datetime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now is: " + now);

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The Data from string is: " + dateFromString);

// Add Additional Time
now.AddHours(1);
Console.WriteLine("One hour from now is: "+ now.AddHours(1));
Console.WriteLine("One hour from now is: "+ now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine(dateOnlyBirth);

// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine(timeOnly);

int day = dateOfBirth.DayOfYear;
Console.WriteLine(day);