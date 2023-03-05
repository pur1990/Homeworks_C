System.Console.WriteLine("Написать программу возведения числа А в целую стень B");
System.Console.WriteLine();
int a = InputNumbers("Введите основание степени: ");
int b = InputNumbers("Введите показатель степени: ");

int exp = a;
for (int i = 1; i < b; i++)
{
    exp = exp * a;
}
System.Console.WriteLine($"{a} в степени {b} равно {exp}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}