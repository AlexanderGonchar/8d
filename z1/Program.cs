Console.WriteLine("Введите числа N и M, N>M");
Console.WriteLine("N = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("M = ");
int m = int.Parse(Console.ReadLine());
void Recursion(int n)
{
    if (n < m) return;
    {
        Recursion(n - 1);
        Console.Write(n + " ");
    }
}
Recursion(n);
