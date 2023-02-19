System.Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат");
System.Console.WriteLine();
int QuarterNum = 0;
int x = ReadInt("Введите координату X первой точки: ");
int y = ReadInt("Введите координату Y первой точки: ");
System.Console.WriteLine($"Координаты точки: ({x}, {y})");
if (x * y == 0) QuarterNum = 0;
else if (x > 0 && y > 0) QuarterNum = 1;
else if (x < 0 && y > 0) QuarterNum = 2;
else if (x < 0 && y < 0) QuarterNum = 3;
else QuarterNum = 4;
System.Console.Write($"Точка с координатами ({x}, {y}) находится ");
if (QuarterNum == 0) System.Console.WriteLine("на одной из оси координат");
else System.Console.WriteLine($"в {QuarterNum}-й четверти");
System.Console.WriteLine();


// Функция ввода сообщения (научился сокращать :-))
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}