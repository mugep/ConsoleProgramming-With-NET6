// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array
int[] grades = new int[5];
// 5 space addressess - 0, 1, 2, 3, 4
// if n is the size of the array, then your array has addresses between 0 to n-1

// Add values to Fixed Size Array
//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;
//grades = new int[] { 1, 24, 38, 46, 58 };
Console.WriteLine("Enter All Grades ");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
// Print values in fixed size array
Console.WriteLine("The Grades you have entered are");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare variable sized array
string [] studentNames = new string[] {"Test", "Student1", "etc..."};
// add values to variable sized array
Console.WriteLine("Enter All Names ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter Name: ");
    studentNames[i] = Console.ReadLine();
}
// print values in variable size array
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}