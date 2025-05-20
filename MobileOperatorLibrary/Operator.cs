using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperatorLibrary
{
    public class Operator : IEnumerable<Subscriber>
    {
        public OperatorName Name { get; }
        public string TaxId { get; }
        private List<Subscriber> _subscribers;

        public int SubscribersCount => _subscribers.Count;

        public Operator(OperatorName name, string taxId, IEnumerable<Subscriber> subscribers)
        {
            Name = name;
            TaxId = taxId;
            _subscribers = subscribers
                .GroupBy(s => s.ContractNumber)
                .Select(g => g.First())
                .ToList();
        }

        public IEnumerator<Subscriber> GetEnumerator() => _subscribers.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}