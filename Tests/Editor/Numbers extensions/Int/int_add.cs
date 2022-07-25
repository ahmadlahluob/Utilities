using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.Utilities.NumbersExtensions.Tests
{
    public static class int_add
    {
        [Test]
        public static void int_equal_to_length()
        {
            int _nm = 1;
            AreEqual( 0, _nm.Add( 0, 1 ) );
        }
        [Test]
        public static void int_less_than_length_by_one()
        {
            int _nm = 1;
            AreEqual( 2, _nm.Add( 0, 2 ) );
        }
        [Test]
        public static void int_less_than_length()
        {
            int _nm = 1;
            AreEqual( 2, _nm.Add( 0, 3 ) );
        }
    }
}