﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class STasks
    {
        static Random rnd = new Random();
        public static void s_task1()
        {
            double value = 100.01;
            Console.WriteLine(value);
        }
        public static void s_task2()
        {
            double e = Math.E;
            Console.WriteLine(Math.Round(e, 1));
        }
        public static void s_task3()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число: " + number);
        }
        public static void s_task4()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " — вот какое число Вы  ввели");
        }
        public static void s_task5()
        {
            Console.Write(1 + " " + 13 + " " + 49);
        }
        public static void s_task6()
        {
            Console.Write(7 + "  " + 15 + "  " + 100);
        }
        public static void s_task7()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + "  " + b + "  " + c);
        }
        public static void s_task8()
        {
            int a = rnd.Next(1, 100);
            int b = rnd.Next(1, 100);
            int c = rnd.Next(1, 100);
            int d = rnd.Next(1, 100);
            Console.Write(a + " " + b + " " + c + " " + d);
        }
        public static void s_task9()
        {
            Console.WriteLine(50 + "\n" + 10);
        }
        public static void s_task10()
        {
            Console.WriteLine(5 + "\n" + 10 + "\n" + 21);
        }
        public static void s_task11()
        {
            int a = rnd.Next(1, 100);
            int b = rnd.Next(1, 100);
            int c = rnd.Next(1, 100);
            int d = rnd.Next(1, 100);
            Console.Write(a + "\n" + b + "\n" + c + "\n" + d);
        }
        public static void s_task12()
        {
            Console.WriteLine(5 + " " + 10);
            Console.WriteLine(7 + " см");
        }
        public static void s_task13()
        {
            Console.WriteLine(2 + " кг");
            Console.WriteLine(13 + " " + 17);
        }
        public static void s_task14()
        {
            int x1 = rnd.Next(1, 10);
            int a = x1;
            double y = 7 * Math.Pow(x1, 2) + 3 * x1 + 6;
            double x2 = 12 * Math.Pow(a, 2) + 7 * a + 12;

            Console.WriteLine(y);
            Console.WriteLine(x2);
        }
        public static void s_task15(int side)
        {
            Console.WriteLine(side * 4);
        }
        public static void s_task16(int r) 
        {
            double d = r * 2;
            Console.WriteLine(d);
        }
        public static void s_task17()
        {
            int radius = 6350;
            int height = rnd.Next(1, 1000);
            int gipotinus = radius + height;
            Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow(gipotinus, 2) - Math.Pow(radius, 2))), 1));
        }
        public static void s_task18(int lenght)
        {
            Console.WriteLine("Объем: " + Math.Pow(lenght, 3));
            Console.WriteLine("Площадь боковой поверхности: " + Math.Pow(lenght, 2));
        }
        public static void s_task19(int radius)
        {
            Console.WriteLine("Длина окружности: " + 2 * Math.PI * radius);
            Console.WriteLine("Плозадь окружности: " + Math.PI * Math.Pow(radius, 2));
        }
        public static void s_task20(int a, int b)
        {
            Console.WriteLine("Среднее арифметическое: " + a + b / 2);
            Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(a * b));
        }
        public static void s_task21(int volume, int mass)
        {
            Console.WriteLine("Плотность равна: " + (double)mass / volume);
        }
        public static void s_task22(int people, int square)
        {
            Console.WriteLine("Плотность населения в государстве: " + (double)people / square);
        }
        public static void s_task23()
        {
            int a = EnterNotNullValue();
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("ax + b = 0 (a != 0)");
            Console.WriteLine("x = " + b / a * -1);
        }
        public static void s_task24(int a, int b)
        {
            Console.WriteLine("Гипотенуза равна: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));            
        }
        public static void s_task25(int inRadius, int outRadius)
        {
            double s1 = Math.PI * Math.Pow(inRadius, 2);
            double s2 = Math.PI * Math.Pow(outRadius, 2);
            Console.WriteLine("Площадь кольца равна: " + (s2 - s1));
        }
        public static void s_task26(int x, int y)
        {
            int z = (int)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Периметр: " + (x + y + z));
        }
        public static void s_task27(int a, int b)
        {
            Console.WriteLine("Среднее арифметическое модулей: " + ((Math.Abs(a) + Math.Abs(b)) / 2));
            Console.WriteLine("Среднее геометрическое модулей: " + (Math.Sqrt((Math.Abs(a) * Math.Abs(b)))));
        }
        public static void s_task28(double appleKoef, double cookieKoef, double candyKoef, double apples, double cookies, double candys)
        {
            Console.WriteLine("Стоимость яблок: " + appleKoef * apples);
            Console.WriteLine("Стоимость печенья: " + cookieKoef * cookies);
            Console.WriteLine("Стоимость конфет: " + candyKoef * candys);
        }
        public static void s_task29(double monitor, double block, double keyboard, double mouse, int amount)
        {
            Console.WriteLine($"Стоимость {amount} компьютеров: {(monitor + block + keyboard + mouse) * amount}");
        }
        public static void z_task1()
        {
            for(int i = 100; i <= 200; ++i)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
        public static void z_task2(int a, int b, int c)
        {
            for (int i = a; i <= b; ++i)
            {
                if (i % c == 0)
                    Console.WriteLine(i);
            }
        }
        public static void z_task3()
        {
            int temp = 0;
            for (int i = 0; i <= 10; ++i)
            {
                if (i % 2 != 0)
                    temp += i;
            }
            Console.WriteLine(temp);
        }
        public static void z_task4(int a, int b)
        {
            int temp = 0;
            for (int i = a; i <= b; ++i)
            {
                if (i % 4 == 0)
                    temp += i;
            }
            Console.WriteLine(temp);
        }
        public void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        private static int EnterNotNullValue()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
                EnterNotNullValue();
            return a;
        }
    }
}
