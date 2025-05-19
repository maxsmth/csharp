using NUnit.Framework;
using MobileOperatorLibrary;

namespace MobileOperatorLibrary.UnitTests
{
    [TestFixture]
    public class SubscriberUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var subscriber = CreateTestSubscriber();

            Assert.That(subscriber.Name, Is.EqualTo("Иван"));
            Assert.That(subscriber.Surname, Is.EqualTo("Иванов"));
            Assert.That(subscriber.ContractNumber, Is.EqualTo("CN-12345"));
        }

        [Test]
        public void GetInfoTest()
        {
            var subscriber = CreateTestSubscriber();
            subscriber.Balance = 150.50m;
            var info = subscriber.GetInfo();

            Assert.That(info[0], Is.EqualTo("Иван Иванов"));
            Assert.That(info[1], Is.EqualTo("Phone: +79001234567. Contract: CN-12345. Tariff: Премиум. Payment Type: Prepaid. Balance: 150.50"));
        }

        private Subscriber CreateTestSubscriber()
        {
            return new Subscriber(
                "Иван",
                "Иванов",
                "+79001234567",
                "CN-12345",
                "Премиум",
                PaymentType.Prepaid);
        }
    }
}