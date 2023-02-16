System.Console.WriteLine("Найти третью цифру числа или сообщить, что её нет");
System.Console.WriteLine();
System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num / 100 < 1)
    Console.Write("Третьей цифры числа нет!");
else
    Console.Write($"Третья цифра введённого Вами числа - {num / 100 % 10}");