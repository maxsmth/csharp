using NUnit.Framework;
using MobileOperatorLibrary;

namespace MobileOperatorLibrary.UnitTests
{
    [TestFixture]
    public class ServiceTests
    {
        private Subscriber _testSubscriber;

        [SetUp]
        public void Setup()
        {
            _testSubscriber = new Subscriber(
                "Иван",
                "Иванов",
                "+79001234567",
                "CN-12345",
                "Премиум",
                PaymentType.Prepaid
            );
        }

        [Test]
        public void CallsService_CalculatePayment_ReturnsCorrectValue()
        {
            var service = new CallsService(_testSubscriber, 0.5m, 100);
            _testSubscriber.UsedMinutes = 150;

            var payment = service.CalculatePayment();

            Assert.That(payment, Is.EqualTo(25.0m));
        }

        [Test]
        public void TextMessageService_CalculatePayment_ReturnsCorrectValue()
        {
            var service = new TextMessageService(_testSubscriber, 0.1m, 50);
            _testSubscriber.SentMessages = 70;

            var payment = service.CalculatePayment();

            Assert.That(payment, Is.EqualTo(2.0m));
        }

        [Test]
        public void InternetService_CalculatePayment_ReturnsCorrectValue()
        {
            var service = new InternetService(_testSubscriber, 0.02m, 1024);
            _testSubscriber.UsedMB = 2048;

            var payment = service.CalculatePayment();

            Assert.That(payment, Is.EqualTo(20.48m));
        }
    }
}