System.Console.WriteLine("В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.");
System.Console.WriteLine();
int m = InputNumbers("Введите количество строк: ");
int n = InputNumbers("Введите количество строк: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int[,] position = new int[1, 2];
position = FindPosition(array, position);
System.Console.Write($"Позиция элемента:");
WriteArray(position);

int[,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLines(array, position, arr);
System.Console.WriteLine("Получившийся массив:");
WriteArray(arr);

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

int[,] FindPosition(int[,] array, int[,] position)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = array[i, j];
            }
        }
    }
    Console.WriteLine($"Mинимальный элемент: {temp}");
    return position;
}

void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
            {
                arrayWithoutLines[k, l] = array[i, j];
                l++;
            }
        }
        l = 0;
        if (positionSmallElement[0, 0] != i)
        {
            k++;
        }
    }
}