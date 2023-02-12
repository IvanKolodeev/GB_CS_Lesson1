// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers are: ");

for (int i = 0; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }  
}