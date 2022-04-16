// See https://aka.ms/new-console-template for more information

//Prototypes - Defines the function(type, name and parametes)
//Definition - Has the code. It contains the code block
//Function Call - Makes the function
//DRY
//YAGNI

//Void Functions - Completes a task and move along
void PrintName ()
{
    Console.WriteLine("Muhamad Gerald");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"the sum of {num1} and {num2} is {num1 + num2}");
}
//Value Returning Functions - Completes a task, return a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if(largest < num2)
    {
        largest = num2;
    }

    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}


PrintName();

Console.WriteLine("Enter Number 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);


Console.WriteLine("Enter Number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"the largest number is: {result}");
//Console.WriteLine($"the largest number is: {LargestNumber(number1, number2, number3)}");