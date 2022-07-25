using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class float_add_clamped
    {
        [Test]
        public static void float_equal_to_length()
        {
            float _nm = 2;
            AreEqual( 2, _nm.AddClamped( 2 ) );
        }
        [Test]
        public static void float_less_than_length()
        {
            float _nm = 1;
            AreEqual( 2, _nm.AddClamped( 3 ) );
        }
        [Test]
        public static void float_less_than_length_by_one()
        {
            float _nm = 1;
            AreEqual( 2, _nm.AddClamped( 2 ) );
        }
    }
}