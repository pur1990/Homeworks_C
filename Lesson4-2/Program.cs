System.Console.WriteLine("Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел");
System.Console.WriteLine();
System.Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(100,999);
}
Console.WriteLine($"Вот наш массив: {string.Join(", ", numbers)}");
int count = 0;
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
Console.WriteLine($"В массиве из {numbers.Length} чисел {count} являются чётными, а {numbers.Length - count} нечётными.");