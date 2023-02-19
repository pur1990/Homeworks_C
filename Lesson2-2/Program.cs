System.Console.WriteLine("По двум заданным числам проверять является ли одно квадратом другого");
System.Console.WriteLine();
System.Console.WriteLine("Введите первое число: ");
string Number1 = Console.ReadLine();
int num1 = Convert.ToInt32(Number1);
System.Console.WriteLine("Введите второе число: ");
string Number2 = Console.ReadLine();
int num2 = Convert.ToInt32(Number2);
string Result = $"Число {num1} не является квадратом числа {num2}";
if (num1 == num2 * num2)
    Result = Result.Replace(" не", "");
System.Console.WriteLine(Result);
string Result2 = $"Число {num2} не является квадратом числа {num1}";
if (num2 == num1 * num1)
    Result2 = Result2.Replace(" не", "");
System.Console.WriteLine(Result2);