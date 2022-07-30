using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class byte_subtract_clamped
    {
        [Test]
        public static void byte_bigger_than_first_index()
        {
            byte _nm = 1;
            AreEqual( 0, _nm.SubtractClamped( 0 ) );
        }

        [Test]
        public static void byte_equal_to_first_index()
        {
            byte _nm = 0;
            AreEqual( 0, _nm.SubtractClamped( 0 ) );
        }
    }
}