System.Console.WriteLine("В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
System.Console.WriteLine();
int[] arr = new int[123];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,999);
}
Console.WriteLine($"Вот наш массив: {string.Join(", ", arr)}");
int count = 0;
for (int z = 0; z < arr.Length; z++)
if (arr[z] >= 10 & arr[z] <= 99)
count++;
Console.WriteLine($"В массиве {count} чисел находятся в отрезке от 10 до 99");