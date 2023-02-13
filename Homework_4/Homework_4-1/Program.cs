
Console.WriteLine("Показать все чётные числа от 1 до N.");

        Console.WriteLine("Введите число");

        int N = Convert.ToInt32(Console.ReadLine());

        int t = 1;
        while (t <= N)
        {
            Console.WriteLine(t);
            t = t + 1;
        }
        Console.WriteLine("Четными будут: ");
        t = 1;
        while (t <= N)
        {
            if (t % 2 == 0)
            {
                Console.WriteLine(t);
            }
            t = t + 1;
        }