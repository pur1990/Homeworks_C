System.Console.WriteLine("Показать последнюю цифру трёхзначного числа");
System.Console.WriteLine();
System.Console.WriteLine("Введите трёхзначное число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num / 100 >= 10 && num / 100 < 1)
{
    Console.Write("Вы ввели не трехзначное число!");
}
else
{
    Console.Write($"Последняя цифра введённого Вами числа - {num % 100 % 10}");
}