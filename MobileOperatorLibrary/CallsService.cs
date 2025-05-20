using System;

namespace MobileOperatorLibrary
{
    public class CallsService : Service
    {
        public decimal CostPerMinute { get; set; }
        public int FreeMinutes { get; set; }

        public CallsService(Subscriber subscriber, decimal costPerMinute, int freeMinutes)
            : base("Звонки", subscriber)
        {
            CostPerMinute = costPerMinute;
            FreeMinutes = freeMinutes;
        }

        public override decimal CalculatePayment()
        {
            int paidMinutes = Math.Max(Subscriber.UsedMinutes - FreeMinutes, 0);
            return paidMinutes * CostPerMinute;
        }
    }
}