System.Console.WriteLine("Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
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

void Pairs(int[] dataArray)
{
    int last = dataArray.Length - 1;
    for (int i = 0; i < dataArray.Length / 2; i++)
    {
        System.Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
        last--;
    }
    if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
    System.Console.WriteLine();
}
Pairs(arr);