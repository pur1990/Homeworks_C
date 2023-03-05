System.Console.WriteLine("Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем");
System.Console.WriteLine();
int numberFirst = InputNumber("Введите первое число: ");
int numberSecond = InputNumber("Введите второе число: ");
int score = InputNumber("Введите сколько чисел показать: ");
PrintNumber(numberFirst, numberSecond, score);

int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int numberFirst, int numberSecond, int score)
{
    int temporary = 0;
    if (score > 0)
    {
        Console.Write(numberFirst + numberSecond + " ");
        temporary = numberFirst;
        numberFirst = numberSecond;
        numberSecond += temporary;
        PrintNumber(numberFirst, numberSecond, score -= 1);
    }
}