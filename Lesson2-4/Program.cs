System.Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");
System.Console.WriteLine();
int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");
int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;
double range2d = Math.Sqrt(A * A + B * B);
double range3d = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками на плоскости равно {range2d}");
Console.WriteLine($"Расстояние между точками в пространстве равно {range3d}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}