using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace RiseOfArabs.DevTool.Utilities.NumbersExtensions.Tests
{
    public static class float_preivous
    {
        [Test]
        public static void float_bigger_than_first_index()
        {
            float _nm = 1;
            AreEqual( 0, _nm.Previous( 1 ) );
        }
        [Test]
        public static void float_equal_to_first_index()
        {
            float _nm = 0;
            AreEqual( 1, _nm.Previous( 2 ) );
        }
    }
}