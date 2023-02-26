System.Console.WriteLine("Найти сумму чисел одномерного массива стоящих на нечетной позиции");
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
int sum = 0;
for (int z = 0; z < arr.Length; z+= 2)
    sum = sum + arr[z];
Console.WriteLine($"Сумма всех чисел на нечётных позициях равна {sum}");