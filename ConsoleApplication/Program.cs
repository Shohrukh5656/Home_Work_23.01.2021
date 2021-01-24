using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //ДЗ №1:
            //Задание 2.


            Console.WriteLine("Введите А:");
            Console.Write("A = ");
            var A1 = decimal.TryParse(Console.ReadLine(), out var a1);
            if (!A1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в (А=)");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Введите B:");
            Console.Write("B = ");
            var B1 = decimal.TryParse(Console.ReadLine(), out var b1);
            if (!B1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в (В=)");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (a1>b1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(А) не может быть больше (В)");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            decimal sum = 0;
            for (decimal i = a1; i < b1; i++)
            {
                if (i==a1)
                {
                    continue;
                }
                Console.WriteLine($"Значения между А и В: {i}");
                sum = sum + i;
            }
            Console.WriteLine($"Сумма всех чисел расположенных между {a1} и {b1} = {sum}");

           
           
            Console.WriteLine("Введите А:");
            Console.Write("A = ");
            var A2 = int.TryParse(Console.ReadLine(), out var a2);
            if (!A2)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в (А=)");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Введите B:");
            Console.Write("B = ");
            var B2 = int.TryParse(Console.ReadLine(), out var b2);
            if (!B2)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в (В=)");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (a2>b2)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(А) не может быть больше (В)");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            for (int I = a2; I < b2; I++)
            {
                if (I==a2)
                {
                    continue;
                }
                if (I % 2==1)
                {
                    int nechot = I;
                    Console.Write($"{nechot}, ");
                }
                Console.WriteLine();
                

            }
            
            
            //Задание 3.

            int i1 = 0, i2 = 0;
            for (int a = 0; a<14; a++)
            {
                for (int b = 0; b < 15; b++)
                {
                    
                    if (b == i1 || b == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i2++;
            }
            for (int b = 0; b < 15; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


            
            //Задание 4.

            Console.Write("Введите сумму вклада: ");
            var Amount = decimal.TryParse(Console.ReadLine(), out var amount);
            if (!Amount)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в Сумму Вклада");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (amount<1000)
            {
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Сумму Вклада не может быть меньше 1000руб.");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Введите месячный процент вклада:");
            var Percent = decimal.TryParse(Console.ReadLine(), out var percent);
            if (!Percent)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в месячный процент вклада");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (1>percent || percent>24)
            {
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Mесячный процент вклада не может быть меньше 1% и больше 24%.");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
            Console.Write("Введите ожидаемую сумму приболи: ");
            var Ozhi = decimal.TryParse(Console.ReadLine(), out var ozhi);
            if (!Ozhi)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в ожидаемую сумму приболи");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (ozhi<amount || ozhi == amount)
            {
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ожидаемая сумма не может быть меньше или равным суммы вклада");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            int month = 0;
            while (amount < ozhi)
            {
                ++month;
                amount+= amount * percent /100;
            }
            Console.WriteLine($"Через {month} месеца ваш вклад будет равнятся {ozhi} рубл.");
            Console.WriteLine($"Ваш итоговый размер вклада через {month} месяца будeт {amount} рубл.");


            //ДЗ №2:
            //Задание 2.

            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());  
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1]) max = i; 
            }
            Console.WriteLine("Наибольшее значение массива: " + array[max]);
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) min = i; 
            }
            Console.WriteLine("Наименьшее значение массива: " + array[min]);



            
        }
    }
}
