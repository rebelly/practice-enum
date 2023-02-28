using System;

namespace ConsoleApp1
{
    class Program
    {
        enum days
        {
            понедельник = 0,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
        }
        static void Main(string[] args)


        {
            int o = 0;
            foreach(var x in Enum.GetNames(typeof(days)))
            {
                o++;
                Console.WriteLine($"{o}: {x}");
            }
            Console.WriteLine("Введите номер дня недели");
            int cur = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Сейчас: {(days)cur}");
            Console.WriteLine("Введите кол-во дней");
            int n = int.Parse(Console.ReadLine());

            int date = (cur + n) % 7;
            Console.WriteLine($"Через {n} дней будет: {(days)date}, {date+1}-ый день недели ");
               
        }
    }
}
