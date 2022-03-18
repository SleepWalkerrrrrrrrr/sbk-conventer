using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            double RtD = 0.0097;
            double DtR = 103.52;
            double valuta = 0;
            double convert = 0;

            Console.WriteLine("Конвентер валют.");
            Console.WriteLine("Пожалуйста, выберите валюту, которую хотите конвентировать. Она автоматически будет конвентирована в противоположную валюту.");
            Console.WriteLine("1. Рубли. 2. Доллары.");

            value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.WriteLine("Вы выбрали рубли. Они будут конвентированы в доллары.");
                    Console.WriteLine("Введите количество валюты.");
                    valuta = double.Parse(Console.ReadLine());
                    convert = valuta * RtD;
                    Console.WriteLine(valuta + "р. = " + convert + "$");
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали доллары. Они автоматически будут конвентированы в рубли.");
                    Console.WriteLine("Введите количество валюты.");
                    valuta = double.Parse(Console.ReadLine());
                    convert = valuta * DtR;
                    Console.WriteLine(valuta + "$ = " + convert + "р.");
                    break;

                default:
                    Console.WriteLine("Вы выбрали неверное значение.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
