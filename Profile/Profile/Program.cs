using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Автор: Антон Туркин
            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку.
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) *используя вывод со знаком $.

            Console.WriteLine("Введите ваше имя");
            String first_name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            String second_name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            String input = Console.ReadLine();
            int age = Int32.Parse(input);

            //Вывод данных а (склеивание)
            Console.WriteLine("Имя: " + first_name + " " + second_name + ". " + "Возраст: " + age);
            // Вывод данных б (форматирование)
            Console.WriteLine("Имя: {0} {1}. Возраст: {2}", first_name, second_name, age);
            // Вывод данных в* (интерполяция)
            Console.WriteLine($"Имя: {first_name} {second_name}. Возраст: {age}");


            //2. Ввести вес и рост человека. 
            //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
            //где m — масса тела в килограммах, h — рост в метрах
            double I;

            Console.WriteLine("Расчитаем ваш индекс массы тела. Введите ваш вес");
            String input_weight = Console.ReadLine();
            Console.WriteLine("Введите ваш рост в метрах");
            String input_height = Console.ReadLine();
            double weight = Double.Parse(input_weight);
            double height = Double.Parse(input_height);
            I = (double)(weight / (height * height));
            Console.WriteLine($"Ваш индекс массы равен: {I}");

            //3 Задание.
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

            // Метод на вход получает координаты точек
            int x1 = 2;
            int x2 = 1;
            int y1 = 4;
            int y2 = 2;

            //a
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:0.##}", r);
            //б
            double r2 = Distance(x1, x2, y1, y2);
            Console.WriteLine("{0:0.##}", r2);


            //4.Написать программу обмена значениями двух переменных.

            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            //a
            int a=4;
            int b=8;

            int temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //б
            int a2 = 3;
            int b2 = 5;

            Console.WriteLine(a2);
            Console.WriteLine(b2);
            a2 = a2 + b2;//8
            b2 = b2 - a2;//-3
            b2 = -b2; //3
            a2 = a2 - b2; //5
            Console.WriteLine(a2);
            Console.WriteLine(b2);

            //5.
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организуйте в центре экрана
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

            Console.WriteLine("введите ваше имя:");
            String name = Console.ReadLine();
            Console.WriteLine("введие ваш город проживания:");
            String city = Console.ReadLine();
            String txt = $"{name}.{city}";
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            //a
            Console.WriteLine(txt);
            //б
            Console.SetCursorPosition(x, y);
            Console.WriteLine(txt);

            //в
            Print(txt, x, y);

            Console.ReadKey();

        }
        // Метод на вход принимает коордтнаты точек и возвращает результат вычислений.
        static double Distance(int x1, int x2, int y1, int y2)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        // Метод принимает на вход строку и координаты курсора.
        static void Print(string txt, int x, int y)
        {            
            Console.SetCursorPosition(x, y);
            Console.WriteLine(txt);
        }
    }
    // 6* Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
    class Education
    {
        static void Print()
        {

        }
        static void Pause()
        {

        }


    }
}
