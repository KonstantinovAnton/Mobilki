using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilki
{
    public class Tasks
    {
       // Вариант 2

       // 1 задание
        public static void task1()
        {
            double argument;
            double basis;
            for (; ; )
            {
                Console.Write("Введите аргумент >> ");
                argument = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите основание >> ");
                basis = Convert.ToDouble(Console.ReadLine());

                if (argument >= 0 && basis >= 0) break;
                else
                {
                    Console.WriteLine("\nВведите положительные значения");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("\nОтвет: " + Math.Log(argument, basis));
        }

        // 2 задание
        public static void task2()
        {
            Console.WriteLine("Введите координаты начала диагонали");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты конца диагонали");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());


            double perimeter = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1)) * 2;
            double square = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

            Console.WriteLine("Площадь: " + square + " Периметр: " + perimeter);
        }

        // 3 задание
        public static void task3()
        {
            Console.Write("Введите число >> ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number % 3 == number % 4) Console.WriteLine("Остаток одинаков"); 
            else Console.WriteLine("Разные остатки"); 
        }

        // 4 задание
        public static void task4()
        {
            Console.Write("Введите число >> ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                var digit = number % 10;
                number /= 10;
                Console.WriteLine(digit);
            }
        }

        // 5 задание
        public static void task5()
        {
            Console.Write("Введите значение x >> ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат вычислений: " + (Math.Log10(Math.Abs(Math.Cos(x)))) / (Math.Log10(1 + x * x))); 
        }

        // 6 задание
        public static void task6()
        {
            Console.Write("Введите кол-во чисел >> ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num0 = 0;
            int num1 = 1;
            int num2;

            Console.WriteLine(num1 + " [1]");

            for (int i = 3; i < n; i++)
            {
                num2 = num0 + num1;

                if(i % 2 == 0)
                    Console.WriteLine(num2 + " ["+(i-1)+"]");

                num0 = num1;
                num1 = num2;
            }
        }

        // 7 задание
        public static void task7()
        {
            Console.Write("Введите кол-во чисел >> ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            double chis = 1;
            double znam = 2;

            for (int i = 0; i < n; i++)
            {
                sum += (chis / znam);
                chis++;
                znam++;
            }

            Console.WriteLine("Сумма равна " + sum); 
        }

        // 8 задание
        public static void task8()
        {
            Console.Write("Введите первое число >> ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число >> ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число >> ");
            double z = Convert.ToDouble(Console.ReadLine());

            if (x + y < 0) Console.WriteLine("Сумма первого и второго числа отрицательная: " + (x+y));
            if (y + z < 0) Console.WriteLine("Сумма второго и третьего числа отрицательная: " + (y + z));
            if (x + z < 0) Console.WriteLine("Сумма первого и третьего числа отрицательная: " + (x + z));

            if (x + y >= 0 && y + z >= 0 && x + z >= 0) Console.WriteLine("Суммы всех чисел положительна");
        }
    }
}
