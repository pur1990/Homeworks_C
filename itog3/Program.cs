System.Console.WriteLine("Найти сумму цифр числа");
System.Console.WriteLine();
int x = InputNumbers("Введите число: ");
int sum = 0;
while (x > 0)
{
    sum = sum + x % 10;
    x = x / 10;
}
System.Console.WriteLine(sum);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}