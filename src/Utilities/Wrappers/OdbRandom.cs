using System;

namespace NDatabase.Utilities.Wrappers
{
    internal static class OdbRandom
    {
        private static readonly Random Random = new Random();

        internal static int GetRandomInteger()
        {
            return Random.Next();
        }

        internal static double GetRandomDouble()
        {
            return Random.NextDouble();
        }
    }
}