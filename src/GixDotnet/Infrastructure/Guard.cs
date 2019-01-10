using System;

namespace GixDotnet.Infrastructure
{ 
    /// <summary>
    ///     Internal asserts
    /// </summary>
    internal static class Guard
    {
        public static void Ensures(bool condition)
        {
            if (!condition)
                throw new InvalidOperationException();
        }

        public static void NotNull(object obj)
        {
            Ensures(obj != null);
        }
    }
}