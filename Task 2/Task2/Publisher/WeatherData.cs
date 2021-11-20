using Task2.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Publisher
{
    public class WeatherData : IPublisher
    {
        private static List<ISubscriber> subscribers = new List<ISubscriber>();
        Random rnd = new Random();

        public void AddSubscriber(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void DeleteSubscriber(ISubscriber sub)
        {
            if (subscribers.Exists(s => s.Equals(sub)))
            {
                subscribers.Remove(sub);
            }
            else
            {
                Console.WriteLine("Такого подписчика не существует");
            }
        }

        public double GetTemperature()
        {
            double t = rnd.Next(0, 35);
            return t;
        }

        public double GetPressure()
        {
            double p = rnd.Next(640, 820);
            return p;
        }

        public double GetSpeed()
        {
            double s = rnd.Next(3, 12);
            return s;
        }

        public void Notify()
        {
            foreach (var item in subscribers)
            {
                item.GetNotify(GetTemperature(), GetPressure(), GetSpeed());
            }
        }
    }
}