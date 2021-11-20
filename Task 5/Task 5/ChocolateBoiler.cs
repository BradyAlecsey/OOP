using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    class ChocolateBoiler
    {
        private Boolean empty;
        private Boolean boiled;
        private volatile static ChocolateBoiler uniqueBoiler;
        private static object locker = new object();
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler getInstanse()     //метод, для создания единственного экземпляра класса
        {
            if(uniqueBoiler == null)
            {
                lock (locker)  //синхрпонизация потоков
                {
                    if (uniqueBoiler == null)
                    {
                        uniqueBoiler = new ChocolateBoiler();
                    }
                }
            }
            return uniqueBoiler;
        }
        public void fill() 
        {
            if (isEmpty()) 
            {
                empty = false;
                Console.WriteLine("заполнение нагревателя..."); 
            }
        }
        public Boolean isEmpty() { return empty; } //проверка на заполненность
        public Boolean isBoiled() { return boiled; } //проверка на температуру
        public void boil()
        {
            if (!isBoiled() && !isEmpty())
            {
                boiled = true;
            }
            Console.WriteLine("нагреваем смесь..."); 
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
                boiled = false;
                Console.WriteLine("сливаем нагретую смесь...");
                
            }
        }
        public void check()
        {
            Console.Write("Бойлер заполнен:");
            if (isEmpty()) { Console.WriteLine(" НЕТ"); }
            else { Console.WriteLine(" ДА"); }
            Console.Write("Смесь нагрета:");
            if (!isBoiled()) { Console.WriteLine(" НЕТ"); }
            else { Console.WriteLine(" ДА"); }
        }
    }
}
