System.Console.WriteLine("В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
System.Console.WriteLine();
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,999);
}
Console.WriteLine($"Вот наш массив: {string.Join(", ", arr)}");
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    max = arr[i];
}
Console.WriteLine($"Максимальное значение = {max}");
int min = arr[0];
for (int z = 0; z < arr.Length; z++)
{
    if (arr[z] < min)
    min = arr[z];
}
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между макс. и мин. значением = {max-min}");