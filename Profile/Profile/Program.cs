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
            // Задание 1. Анкета
            Console.WriteLine("Введите ваше имя");
            String first_name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            String second_name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            String input = Console.ReadLine();
            int age = Int32.Parse(input);

            // Вывод данных а (конкатенация)
            Console.WriteLine("Имя: "+first_name+" "+second_name+". "+"Возраст: "+age );
            // Вывод данных б (форматирование)
            Console.WriteLine("Имя: {0} {1}. Возраст: {2}", first_name,second_name,age);
            // Вывод данных в* (интерполяция)
            Console.WriteLine($"Имя: {first_name} {second_name}. Возраст: {age}");

            Console.ReadKey();

        }
    }
}
