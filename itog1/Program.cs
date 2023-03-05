System.Console.WriteLine("Показать натуральные числа от M до N, N и M заданы");
System.Console.WriteLine();
int m = InputNumbers("Введите число N: ");
int n = InputNumbers("Введите число M: ");
string numbers(int m, int n)
{
    if (m <= n) return numbers(m + 1, n) + $" {m}";
    else return String.Empty;
}
System.Console.WriteLine(numbers(m, n));

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}