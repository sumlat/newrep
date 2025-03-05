// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("enter first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(3, 5));
static int SumNumbers(int num1, int num2)
{
    return num1 + num2;
}