using System;
using System.Collections.Generic;
using System.Text;
using Task2.Subscribers;

namespace Task2.Publisher
{
    public delegate void WeatherPublisherHandler(double temp, double humidity, double pressure);
    class EventWeatherData : IPublisher
    {
        Random rnd = new Random();

        public event WeatherPublisherHandler Notify;
        public void AddSubscriber(ISubscriber sub)
        {
            Notify += sub.GetNotify;
        }
        public void DeleteSubscriber(ISubscriber sub)
        {
            Notify -= sub.GetNotify;
        }

        public void NotifySubs()
        {
            Notify.Invoke(GetTemperature(), GetPressure(), GetSpeed());
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


    }
}