Console.WriteLine("Найти максимальное из трех чисел");
Console.WriteLine("Введите одно из трех чисел: 22, 3, 9");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 22)
{
    Console.WriteLine("Это максимальное число");
}
if (number == 9)
{
    Console.WriteLine("Это среднее число");
}
if (number == 3)
{
    Console.WriteLine("Это минимальное число");
}
