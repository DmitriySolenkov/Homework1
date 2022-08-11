Console.Clear();
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.WriteLine("Max = " + num1 + ", min = "+ num2);
}
if (num1<num2)
{
    Console.WriteLine("Max = " + num2 + ", min = "+ num1);
}
if (num1==num2)
{
    Console.WriteLine("Numbers are equal");
}