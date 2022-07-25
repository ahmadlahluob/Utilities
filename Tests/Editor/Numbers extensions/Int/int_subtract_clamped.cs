using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class int_subtract_clamped
    {
        [Test]
        public static void int_bigger_than_first_index()
        {
            int _nm = 1;
            AreEqual( 0, _nm.SubtractClamped( 0 ) );
        }

        [Test]
        public static void int_equal_to_first_index()
        {
            int _nm = 0;
            AreEqual( 0, _nm.SubtractClamped( 0 ) );
        }
    }
}