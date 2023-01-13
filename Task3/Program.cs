Console.WriteLine("Is your number even?");
Console.WriteLine("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0)
{
    Console.WriteLine("It is even number");
}
else
{
    Console.WriteLine("It is not even number");
}
