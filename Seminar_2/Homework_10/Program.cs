using System;

namespace homework
{    class Program
    {
        static void Main()
        {
           Finder(567);
        }
        public static void Print(string word){
            Console.WriteLine(word);
        }
          
        public static void Finder(int numberA)
        {
            Print("Введите трезначное число:");
            numberA = Convert.ToInt32(Console.ReadLine());
            bool treeDigit = numberA > 99 && numberA < 1000;
            
                numberA = numberA / 10 % 10;
    
            Console.WriteLine(numberA);
        }
    }

}

