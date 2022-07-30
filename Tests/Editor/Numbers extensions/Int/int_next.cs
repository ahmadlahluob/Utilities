using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class int_next
    {
        [Test]
        public static void int_equal_to_length()
        {
            int _nm = 1;
            AreEqual( 0, _nm.Next( 1 ) );
        }
        [Test]
        public static void int_less_than_length_by_one()
        {
            int _nm = 1;
            AreEqual( 0, _nm.Next( 2 ) );
        }
        [Test]
        public static void int_less_than_length()
        {
            int _nm = 1;
            AreEqual( 2, _nm.Next( 3 ) );
        }
    }
}