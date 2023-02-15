System.Console.WriteLine("Найти максимальное из трех чисел");
System.Console.WriteLine();
System.Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
System.Console.Write("Введите второе число: ");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);
System.Console.Write("Введите третье число: ");
string number3 = Console.ReadLine();
int num3 = Convert.ToInt32(number3);
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное число = {max}");