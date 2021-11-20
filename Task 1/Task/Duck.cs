using System;
using System.Collections.Generic;
using System.Text;
using Task.Swim;

namespace Task
{
    public abstract class Duck
    {
        private protected IFlyBehavior _flyBehavior;
        private protected IQackBehavior _qackBehavior;
        private protected ISwimable _swimable;
        
        public Duck(IFlyBehavior flyBehavior, IQackBehavior quackBehavior, ISwimable swimable)
        {
            _flyBehavior = flyBehavior;
            _qackBehavior = quackBehavior;
            _swimable = swimable;
        }
        public void Display()
        {
            _flyBehavior.Fly();
            _qackBehavior.Qack();
            _swimable.Swim();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Qack()
        {
            _qackBehavior.Qack();
        }

        public void Swim()
        {
            _swimable.Swim();
        }
        public void Dead()
        {
            Console.WriteLine("Оно мертво.");
            _flyBehavior = new NoFly();
            _qackBehavior = new NoQack();
            _swimable = new NotSwimable();
        }
    }
}