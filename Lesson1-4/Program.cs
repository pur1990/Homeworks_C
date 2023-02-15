System.Console.WriteLine("Выяснить является ли число чётным");
System.Console.WriteLine();
System.Console.Write("Введите число: ");
string writeNumber = Console.ReadLine();
int number = Convert.ToInt32(writeNumber);
string result = "Введённое Вами число не является чётным";
if (number % 2 == 0)
{
    result = result.Replace(" не", "");
}
System.Console.WriteLine(result);