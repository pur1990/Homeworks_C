System.Console.WriteLine("Задача 1:");
System.Console.WriteLine("Введите первое число: ");
string Number1 = Console.ReadLine();
int num1 = Convert.ToInt32(Number1);

System.Console.WriteLine("Введите второе число: ");
string Number2 = Console.ReadLine();
int num2 = Convert.ToInt32(Number2);

string Result = $"Число {num1} не является квадратом числа {num2}";

if (num1 == num2 * num2)
{
    Result = Result.Replace(" не", "");
}
System.Console.WriteLine(Result);
System.Console.WriteLine();