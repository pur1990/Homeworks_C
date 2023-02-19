System.Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
System.Console.WriteLine();
System.Console.Write("Введите число: ");
string writeNum = Console.ReadLine();
int num = Convert.ToInt32(writeNum);
int cube = 0;
for (int x = 1; x <= num; x++)
{
    if (x % 2 != 0)
        continue;
    cube = x * x * x;
    System.Console.WriteLine($"{x} в кубе = {cube}");
}