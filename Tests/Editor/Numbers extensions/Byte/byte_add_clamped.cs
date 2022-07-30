using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class byte_add_clamped
    {
        [Test]
        public static void byte_equal_to_length()
        {
            byte _nm = 2;
            AreEqual( 2, _nm.AddClamped( 2 ) );
        }
        [Test]
        public static void byte_less_than_length()
        {
            byte _nm = 1;
            AreEqual( 2, _nm.AddClamped( 3 ) );
        }
        [Test]
        public static void byte_less_than_length_by_one()
        {
            byte _nm = 1;
            AreEqual( 2, _nm.AddClamped( 2 ) );
        }
    }
}