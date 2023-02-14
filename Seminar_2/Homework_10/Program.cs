Console.WriteLine("Введите трезначное число:");

int numberA = Convert.ToInt32(Console.ReadLine());

if ( numberA / 100 > 1)
{
    numberA = numberA / 10 % 10;
}
Console.WriteLine(numberA);