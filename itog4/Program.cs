System.Console.WriteLine("Написать программу вычисления функции Аккермана");
System.Console.WriteLine();
int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");
int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n, m);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
System.Console.WriteLine(Akk(m, n));