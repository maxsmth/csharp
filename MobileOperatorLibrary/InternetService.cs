using System;

namespace MobileOperatorLibrary
{
    public class InternetService : Service
    {
        public decimal CostPerMB { get; set; }
        public int FreeMB { get; set; }

        public InternetService(Subscriber subscriber, decimal costPerMB, int freeMB)
            : base("Интернет", subscriber)
        {
            CostPerMB = costPerMB;
            FreeMB = freeMB;
        }

        public override decimal CalculatePayment()
        {
            int paidMB = Math.Max(Subscriber.UsedMB - FreeMB, 0);
            return paidMB * CostPerMB;
        }
    }
}