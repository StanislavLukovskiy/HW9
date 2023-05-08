int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        n = Akk(m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = Akk(m, n - 1);
        n = Akk(m - 1, n);
    }
    return n;
}

int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
Console.WriteLine($"A ({m}, {n}) = {Akk(m, n)}");