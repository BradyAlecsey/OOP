using Task2.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber sub);
        void DeleteSubscriber(ISubscriber sub);
    }
}