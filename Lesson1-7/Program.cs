System.Console.WriteLine("Показать вторую цифру трёхзначного числа");
System.Console.WriteLine();
System.Console.WriteLine("Введите трёхзначное число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num / 100 >= 10 || num / 100 < 1)
    Console.Write("Вы ввели не трехзначное число!");
else
    Console.Write($"Вторая цифра введённого Вами числа - {num / 10 % 10}");