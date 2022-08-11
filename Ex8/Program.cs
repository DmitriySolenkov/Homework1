Console.Clear();
Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    Console.Write(count+", ");
    count = count + 2;
}