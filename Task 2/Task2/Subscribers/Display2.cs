using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2.Publisher;

namespace Task2.Subscribers
{
    public class Display2 : ISubscriber
    {
        public Display2(IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }

        private static List<double> tempList = new List<double>() { 18, 34, 27 };
        private static List<double> pressureList = new List<double>() { 650, 703, 711, 750 };
        private static List<double> speedList = new List<double>() { 5, 8, 4, 5 };

        public void GetNotify(double temp, double pressure, double speed)
        {
            tempList.Add(temp);
            pressureList.Add(pressure);
            speedList.Add(speed);

            Console.WriteLine("-------Средние значения за сегодня:-------");
            Console.WriteLine($"Средняя температура: {FindAverage(tempList):0.####} град. Цельсия");
            Console.WriteLine($"Среднее давление: {FindAverage(pressureList):0.###} мм. рт. ст.");
            Console.WriteLine($"Средняя скорость ветра: {FindAverage(speedList):0.###} м/с");
            Console.WriteLine("------------------------------------------");
        }

        private static double FindAverage(List<double> data)
        {
            double aver;
            aver = data.Average();
            return aver;
        }
    }
}