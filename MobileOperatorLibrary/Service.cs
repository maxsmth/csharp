using System;

namespace MobileOperatorLibrary
{
    public abstract class Service
    {
        public string Name { get; set; }
        public Subscriber Subscriber { get; set; }

        protected Service(string name, Subscriber subscriber)
        {
            Name = name;
            Subscriber = subscriber;
        }

        public abstract decimal CalculatePayment();
    }
}