int i;

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}