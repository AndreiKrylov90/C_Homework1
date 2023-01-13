Console.WriteLine("All even less than yours?");
Console.WriteLine("Enter your positive number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= number)
{
    if (i == number)
    {
    Console.Write(i);
    }
    else
    {
    if ((i + 1) == number)
    {
       Console.Write(i); 
    }
    else 
    {
        Console.Write(i + ", ");
    }
    }
i = i + 2;
}
