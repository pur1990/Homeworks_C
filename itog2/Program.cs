System.Console.WriteLine("Найти сумму элементов от M до N, N и M заданы");
System.Console.WriteLine();
int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");
int sum(int n,int m)
{ 
    if(n == 0) return 0;
    else return sum(n - 1, m) + n;
}
System.Console.WriteLine($"Сумма = {sum(n, m)}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}