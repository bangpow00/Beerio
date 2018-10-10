using System;

namespace Beerio.Exceptions
{
    public class CustomContract
        {
            public static void Requires<TException>(bool Predicate)
                where TException : Exception, new()
            {
                if (!Predicate)
                {
                    throw new TException();
                }
            }
        }
}
