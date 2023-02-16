System.Console.WriteLine("Удалить вторую цифру трёхзначного числа");
System.Console.WriteLine();
System.Console.WriteLine("Введите трёхзначное число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
int newNum = 0;
newNum = num / 100 * 10 + num % 10;
System.Console.WriteLine($"Если из введённого Вами числа удалить вторую цифру, получится число {newNum}");