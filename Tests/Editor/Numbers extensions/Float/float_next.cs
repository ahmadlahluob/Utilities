using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class float_next
    {
        [Test]
        public static void float_equal_to_length()
        {
            float _nm = 1;
            AreEqual( 0, _nm.Next( 1 ) );
        }
        [Test]
        public static void float_less_than_length_by_one()
        {
            float _nm = 1;
            AreEqual( 0, _nm.Next( 2 ) );
        }
        [Test]
        public static void float_less_than_length()
        {
            float _nm = 1;
            AreEqual( 2, _nm.Next( 3 ) );
        }
    }
}