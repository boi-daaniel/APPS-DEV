Console.Write("Enter number 1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number 2: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number 3: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2 + num3;
Console.WriteLine("Sum: " + sum);

double average = sum / 3;
Console.WriteLine("Average: " + average);

if (average >= 75)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Failed");
}