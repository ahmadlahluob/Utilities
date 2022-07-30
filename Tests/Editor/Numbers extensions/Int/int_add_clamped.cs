using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class int_add_clamped
    {
        [Test]
        public static void int_equal_to_length()
        {
            int _nm = 2;
            AreEqual( 2, _nm.AddClamped( 2 ) );
        }
        [Test]
        public static void int_less_than_length()
        {
            int _nm = 1;
            AreEqual( 2, _nm.AddClamped( 3 ) );
        }
        [Test]
        public static void int_less_than_length_by_one()
        {
            int _nm = 1;
            AreEqual( 2, _nm.AddClamped( 2 ) );
        }
    }
}