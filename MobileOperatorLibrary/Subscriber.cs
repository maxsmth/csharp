using System;

namespace MobileOperatorLibrary
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string TariffName { get; set; }
        public decimal Balance { get; set; }

        public readonly string ContractNumber;
        public readonly PaymentType PaymentType;

        public int UsedMinutes { get; set; }
        public int SentMessages { get; set; }
        public int UsedMB { get; set; }

        public Subscriber(
            string name,
            string surname,
            string phoneNumber,
            string contractNumber,
            string tariffName,
            PaymentType paymentType)
        {
            if (contractNumber == null)
                throw new ArgumentNullException(nameof(contractNumber));

            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            ContractNumber = contractNumber;
            TariffName = tariffName;
            PaymentType = paymentType;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Name} {Surname}";
            info[1] = $"Phone: {PhoneNumber}. Contract: {ContractNumber}. Tariff: {TariffName}. Payment Type: {PaymentType}. Balance: {Balance}";
            return info;
        }
    }
}