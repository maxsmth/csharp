using System;

namespace MobileOperatorLibrary
{
    public class TextMessageService : Service
    {
        public decimal CostPerMessage { get; set; }
        public int FreeMessages { get; set; }

        public TextMessageService(Subscriber subscriber, decimal costPerMessage, int freeMessages)
            : base("Текстовые сообщения", subscriber)
        {
            CostPerMessage = costPerMessage;
            FreeMessages = freeMessages;
        }

        public override decimal CalculatePayment()
        {
            int paidMessages = Math.Max(Subscriber.SentMessages - FreeMessages, 0);
            return paidMessages * CostPerMessage;
        }
    }
}