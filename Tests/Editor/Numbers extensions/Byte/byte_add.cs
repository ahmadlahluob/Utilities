using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class byte_add
    {
        [Test]
        public static void byte_equal_to_length()
        {
            byte _nm = 1;
            AreEqual( 0, _nm.Add( 0, 1 ) );
        }
        [Test]
        public static void byte_less_than_length_by_one()
        {
            byte _nm = 1;
            AreEqual( 2, _nm.Add( 0, 2 ) );
        }
        [Test]
        public static void byte_less_than_length()
        {
            byte _nm = 1;
            AreEqual( 2, _nm.Add( 0, 3 ) );
        }
    }
}