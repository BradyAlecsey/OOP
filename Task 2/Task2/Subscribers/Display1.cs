using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Publisher;

namespace Task2.Subscribers
{
    public class Display1 : ISubscriber
    {
        public Display1(IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }

        public void GetNotify(double t, double p, double h)
        {
            Console.WriteLine("---------Погода на данный момент:---------");
            Console.WriteLine($"Температура: {t} град. Цельсия");
            Console.WriteLine($"Давление: {p} мм.рт.ст");
            Console.WriteLine($"Скорость ветра: {h} м/с");
            Console.WriteLine("------------------------------------------");
        }
    }
}