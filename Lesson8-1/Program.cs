System.Console.WriteLine("Найти произведение двух матриц");
System.Console.WriteLine();
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы: ");
int o = InputNumbers("Введите число строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMx = new int[m, n];
CreateArray(firstMx);
System.Console.WriteLine($"Первая матрица:");
WriteArray(firstMx);

int[,] secondMx = new int[o, p];
CreateArray(secondMx);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMx);

int[,] resultMx = new int[m, p];

MultiplyMatrix(firstMx, secondMx, resultMx);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMx);

void MultiplyMatrix(int[,] firstMx, int[,] secondMx, int[,] resultMx)
{
    for (int i = 0; i < resultMx.GetLength(0); i++)
    {
        for (int j = 0; j < resultMx.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMx.GetLength(1); k++)
            {
                sum += firstMx[i, k] * secondMx[k, j];
            }
            resultMx[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}