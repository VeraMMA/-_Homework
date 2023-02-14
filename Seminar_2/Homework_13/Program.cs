Console.WriteLine("Вывести третью цифру заданного числа или сообщить, что третьей цифры нет.");
Console.WriteLine("Введите число:");

int numberX = Convert.ToInt32(Console.ReadLine());

if (numberX < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

if (numberX > 1000)
{
    numberX = numberX / 10 % 10;
    Console.WriteLine(numberX);
}

if (numberX < 1000 && numberX > 100)
{
    numberX = numberX % 10;
    Console.WriteLine(numberX);
}
