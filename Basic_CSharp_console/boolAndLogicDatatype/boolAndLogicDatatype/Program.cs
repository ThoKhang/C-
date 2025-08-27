// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a, b;
Console.WriteLine("enter a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("enter b: ");
b = double.Parse(Console.ReadLine());
bool result;
result = a == b;
Console.WriteLine(result);
// > < == >= <= != && || !