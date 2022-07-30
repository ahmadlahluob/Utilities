using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class byte_preivous_clamped
    {
        [Test]
        public static void byte_bigger_than_first_index()
        {
            byte _nm = 1;
            AreEqual( 0, _nm.PreviousClamped() );
        }

        [Test]
        public static void byte_equal_to_first_index()
        {
            byte _nm = 0;
            AreEqual( 0, _nm.PreviousClamped() );
        }
    }
}