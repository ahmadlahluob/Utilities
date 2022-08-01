using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class Byte
    {
        /// <returns>Random value from 0 to 1</returns>
        public static byte Random01 => (byte)Random.Range( 0, 2 );

        /// <returns>Random value from 0 to 100</returns>
        public static byte RandomPercent => (byte)Random.Range( 0, 101 );

        /// <returns>Random value from 0 to 10</returns>
        public static byte RandomFromTen => (byte)Random.Range( 0, 11 );

        /// <returns>Random value from 0 to 5</returns>
        public static byte RandomFromFive => (byte)Random.Range( 0, 6 );
    }
}