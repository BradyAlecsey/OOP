using System;
using Task2.Publisher;
using Task2.Subscribers;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            EventWeatherData eventWeatherData = new EventWeatherData();
            Display1 display1 = new Display1(eventWeatherData);
            Display2 display2 = new Display2(eventWeatherData);
            eventWeatherData.NotifySubs();
        }
    }
}