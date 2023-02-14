 {
        Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток.");

       
        Console.WriteLine("Введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число ");
         int b = Convert.ToInt32(Console.ReadLine());
   
        if (a % b == 0)
        {
            Console.WriteLine("Числа кратные");
        }
        else Console.WriteLine(a % b);
        
    }
    