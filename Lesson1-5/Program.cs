System.Console.WriteLine("Показать четные числа от 1 до N");
System.Console.WriteLine();
System.Console.Write("Введите число: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);
int num = 0;
System.Console.WriteLine($"Чётные числа из диапазона от 1 до {N}:");
while (num < N)
{
    num++;
    if (num % 2 == 0) System.Console.Write($"{num} ");
}