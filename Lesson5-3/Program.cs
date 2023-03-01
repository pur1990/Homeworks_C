System.Console.WriteLine("Написать программу копирования массива");
System.Console.WriteLine();
int[] arr = {1, 2, 3, 4, 5};
int[] copy = new int[arr.Length];
arr.CopyTo(copy, 0);
System.Console.WriteLine(String.Join(", ", copy));