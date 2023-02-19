System.Console.WriteLine("Написать программу вычисления произведения чисел от 1 до N");
System.Console.WriteLine();
System.Console.Write("Введите число: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);
int comp = 1;
for (int i = 1; i <= N; i++)
{
    comp = comp * i;
}
System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {comp}");