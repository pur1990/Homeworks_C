System.Console.WriteLine("Подсчитать сумму цифр в числе");
System.Console.WriteLine();
int number = ReadInt("Введите любое число: ");
int sum = 0;
System.Console.Write($"Сумма цифр числа {number} равна ");
while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}
System.Console.WriteLine(sum);


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}