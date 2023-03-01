System.Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
System.Console.WriteLine();
System.Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
/// k1 * x + b1 = k2 * x + b2
/// (k1 - k2) * x = b2 - b1
var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
System.Console.WriteLine($"Пересечение прямых в точке: ({x};{y})");