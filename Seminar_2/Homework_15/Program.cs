Console.WriteLine("По числу обозначить день недели, определить является ли этот день выходным.");

int day = 7;

string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine(days[day - 1]);

if (day >= 1 && day <= 5)
{
    Console.WriteLine("Будний день");
}
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной");
}