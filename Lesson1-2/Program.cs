System.Console.WriteLine("По заданному номеру дня недели вывести его название");
System.Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

System.Console.Write("Введите номер дня недели:   ");
string writeDay = Console.ReadLine();
int dayNumber = Convert.ToInt32(writeDay);

System.Console.WriteLine();
if (0 < dayNumber && dayNumber < 8) System.Console.WriteLine($"Это - {Days[dayNumber - 1]}");
else System.Console.WriteLine("Дня недели с таким номером не существует");
System.Console.WriteLine();