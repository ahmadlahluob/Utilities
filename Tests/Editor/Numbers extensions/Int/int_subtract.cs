using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class int_subtract
    {
        [Test]
        public static void int_bigger_than_first_index()
        {
            int _nm = 1;
            AreEqual( 0, _nm.Subtract( 0, 1 ) );
        }
        [Test]
        public static void int_equal_to_first_index()
        {
            int _nm = 0;
            AreEqual( 2, _nm.Subtract( 0, 2 ) );
        }
    }
}