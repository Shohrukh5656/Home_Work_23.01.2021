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

            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j <= height; j++)
            {
                for (int i = 0; i <= width; i++)
                {
                    if ((i == 0 || i == width) || (j == 0 || j == height))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");    
                    }
                }
                Console.WriteLine();
            }


            Console.Write("Введите высоту Прямоугольного треугольника: ");
            int height2 = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину Прямоугольного треугольника: ");
            int width2 = int.Parse(Console.ReadLine());

            int i1 = 0, i2 = 0;
            for (int a = 0; a < height2; a++)
            {
                for (int b = 0; b < width2; b++)
                {
                    
                    if (b == i1 || b == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i2++;
            }
            for (int b = 0; b < height2; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("Введите значения Равносторонного треугольника: ");
            int ravno = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ravno; i++)
            {
                for (int k = ravno - 1; k >= i; k--)
                {
                    System.Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if ((j == 1 || i == j || i == ravno))
                    {
                        System.Console.Write("* ");
                    }
                    else
                    {
                        System.Console.Write("  ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
                        

            Console.Write("Введите значения Ромба:");
            int romb=int.Parse(Console.ReadLine());
            int f=romb/2+1;
            for(int i=1;i<=romb;i++)
            {
                for(int j=1;j<=romb;j++)
                {
                    if((j==f|| j==romb-f+1))
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                if(i<=romb/2)
                {
                    f--;
                }
                else
                {
                    f++;
                }
            System.Console.WriteLine();
            }


            
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
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            double max = array[0];
            double min = array[0];
            double summ = 0;
            double arif = 0;
           
            System.Console.Write("Все нечетные значения: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (max<=array[i]) max = array[i]; 
                if (min>=array[i]) min = array[i];
                summ += array[i];
                if (array[i] % 2 ==1) Console.Write(array[i]+ ", ");

            }
            Console.WriteLine();
            arif = summ / array.Length;
            Console.WriteLine("Наибольшее значение массива: " + max);
            Console.WriteLine("Наименьшее значение массива: " + min);
            Console.WriteLine("Общая сумма всех элементов массива: " + summ);
            Console.WriteLine("Среднее арифметическое всех элементов массива: " + arif);

            
            //Задание 3.

            Console.WriteLine("Введите размер масива:");
            int mas = Convert.ToInt32(Console.ReadLine());
            int[]arryed = new int[mas];
            Random rand = new Random();
            for(int j = 0; j < arryed.Length; j++)
            {
                arryed[j] = rand.Next(1000);
                Console.WriteLine($"array[{j}]=" + arryed[j]);
            }
            Console.WriteLine();
            Console.WriteLine("В порядковом виде:");
            for(int j = 0; j < arryed.Length; j++)
            {
                Console.WriteLine($"array[{j}]=" + arryed[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Инвертированным виде:");
            for(int j = arryed.Length-1; j >= 0; j--)
            {
                Console.WriteLine($"array= " + arryed[j]);
            }
            Console.WriteLine();


            //Задание 4.

            Console.Write("Введите размер масива: ");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[]arrayed1 = new int[arrsize];
            for(int t = 0; t < arrayed1.Length; t++)
            {
                arrayed1[t] = random.Next(1000);
            }
            Console.WriteLine();
            for(int t = 0; t < arrayed1.Length; t++)
            {
                Console.WriteLine($"array=[{t}]=" + arrayed1[t]);
            }
            Console.WriteLine();

            Console.Write("count = ");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.Write("index = ");
            int index = Convert.ToInt32(Console.ReadLine());
            int []arr4 = new int[Count];
            for(int l = 0; l < Count; l++)
            {
                if(l + index < arrayed1.Length)
                {
                    arr4[l] = arrayed1[l + index];
                }
                else
                {
                    arr4[l] = 1;
                }
            }

            System.Console.WriteLine("Новый массив: ");
            for(int l = 0; l < arr4.Length; l++)
            {
                Console.WriteLine($"new array[{l}]=" + arr4[l]);
            }
        }
    }
}
