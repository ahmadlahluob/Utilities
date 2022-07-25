using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class float_subtract_clamped
    {
        [Test]
        public static void float_bigger_than_first_index()
        {
            float _nm = 1;
            AreEqual( 0, _nm.SubtractClamped( 0 ) );
        }

        [Test]
        public static void float_equal_to_first_index()
        {
            float _nm = 0;
            AreEqual( 0, _nm.SubtractClamped( 0 ) );
        }
    }
}