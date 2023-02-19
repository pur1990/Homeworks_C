System.Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
System.Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
System.Console.Write("Введите номер дня недели: ");
string writeDay = Console.ReadLine();
int dayNumber = Convert.ToInt32(writeDay);
System.Console.WriteLine();
if (0 < dayNumber && dayNumber < 5)
    System.Console.WriteLine($"Это будет {Days[dayNumber - 1]} - это будний день!");
else if (dayNumber == 6 || dayNumber == 7)
    System.Console.WriteLine($"Ура! Это {Days[dayNumber - 1]}, и это выходной день!");
else
    System.Console.WriteLine("Дня недели с таким номером не существует!");