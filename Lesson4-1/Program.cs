System.Console.WriteLine("Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
System.Console.WriteLine();
int n = 8;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));