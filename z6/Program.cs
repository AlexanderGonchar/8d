int Any(int num1, int num2, int pos)
{
    if (pos <= 1) return num1 + num2;
    return Any(num1, num2, pos - 1) + Any(num1, num2, pos - 2);
}
Console.WriteLine("Первая цифра?");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра?");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество цифр?");
int size = int.Parse(Console.ReadLine());
for (int i = 1; i <= size; i++)
{
    Console.Write($"{Any(first, second, i)} ");
}
