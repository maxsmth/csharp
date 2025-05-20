using System.Collections.Generic;

namespace MobileOperatorLibrary
{
    public class PhoneNumberComparer : IComparer<Subscriber>
    {
        public int Compare(Subscriber x, Subscriber y)
        {
            return x.PhoneNumber.CompareTo(y.PhoneNumber);
        }
    }
}