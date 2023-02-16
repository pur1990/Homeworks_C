System.Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток.");
System.Console.WriteLine();
int num1 = new Random().Next(11, 101);
int num2 = new Random().Next(1, 11);
Console.WriteLine($"Были выбраны случайным образом числа {num1} и {num2}");
int result = num1 % num2;
if (result == 0)
    System.Console.WriteLine($"Число {num1} кратно числу {num2}");
else
    Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток от деления равен {num1 % num2}");