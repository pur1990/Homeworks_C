System.Console.WriteLine("Найти кубы чисел от 1 до N");
System.Console.WriteLine();
int num = ReadInt("Введите число: ");
for (int i = 1; i <= num; i++)
{
Console.WriteLine($"{i} в кубе = {i * i * i}");
}
Console.WriteLine();


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}