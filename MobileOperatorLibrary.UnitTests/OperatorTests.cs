using NUnit.Framework;
using MobileOperatorLibrary;
using System.Collections.Generic;

namespace MobileOperatorLibrary.UnitTests
{
    [TestFixture]
    public class OperatorTests
    {
        private Subscriber _subscriber1;
        private Subscriber _subscriber2;
        private Operator _operator;

        [SetUp]
        public void Setup()
        {
            _subscriber1 = new Subscriber(
                "Иван",
                "Иванов",
                "+79001234567",
                "CN-12345",
                "Премиум",
                PaymentType.Prepaid
            );

            _subscriber2 = new Subscriber(
                "Анна",
                "Петрова",
                "+79009876543",
                "CN-67890",
                "Базовый",
                PaymentType.Credit
            );

            var subscribers = new List<Subscriber> { _subscriber1, _subscriber2 };
            _operator = new Operator(OperatorName.MTS, "123456789", subscribers);
        }

        [Test]
        public void CompareTo_SortsBySurnameThenName()
        {
            var subscribers = new List<Subscriber> { _subscriber2, _subscriber1 };
            subscribers.Sort();

            Assert.That(subscribers[0].Surname, Is.EqualTo("Иванов"));
            Assert.That(subscribers[1].Surname, Is.EqualTo("Петрова"));
        }

        [Test]
        public void PhoneNumberComparer_SortsByPhoneNumber()
        {
            var subscribers = new List<Subscriber> { _subscriber1, _subscriber2 };
            subscribers.Sort(new PhoneNumberComparer());

            Assert.That(subscribers[0].PhoneNumber, Is.EqualTo("+79001234567"));
            Assert.That(subscribers[1].PhoneNumber, Is.EqualTo("+79009876543"));
        }

        [Test]
        public void Operator_ExcludesDuplicates()
        {
            var duplicateSubscriber = new Subscriber(
                "Иван",
                "Иванов",
                "+79001234567",
                "CN-12345",
                "Премиум",
                PaymentType.Prepaid
            );

            var operatorWithDuplicates = new Operator(
                OperatorName.MTS,
                "123456789",
                new List<Subscriber> { _subscriber1, duplicateSubscriber }
            );

            Assert.That(operatorWithDuplicates.SubscribersCount, Is.EqualTo(1));
        }

        [Test]
        public void Operator_ImplementsIEnumerable()
        {
            int count = 0;
            foreach (var subscriber in _operator)
                count++;

            Assert.That(count, Is.EqualTo(2));
        }
    }
}