Console.WriteLine("Введите числа N и M, N>=M");
Console.WriteLine("N = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("M = ");
int m = int.Parse(Console.ReadLine());
int sum(int n)
{
    if (n == m) return n;
    return n + sum(n - 1);
}
Console.Write(sum(n));
