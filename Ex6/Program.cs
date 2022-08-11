Console.Clear();
Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 2;
if (num2 == 0)
{
    Console.Write("Number is even!");
}
else
{
    Console.Write("Number is not even!");
}