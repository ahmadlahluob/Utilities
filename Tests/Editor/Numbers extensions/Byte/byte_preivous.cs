using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class byte_preivous
    {
        [Test]
        public static void byte_bigger_than_first_index()
        {
            byte _nm = 1;
            AreEqual( 0, _nm.Previous( 1 ) );
        }
        [Test]
        public static void byte_equal_to_first_index()
        {
            byte _nm = 0;
            AreEqual( 1, _nm.Previous( 2 ) );
        }
    }
}