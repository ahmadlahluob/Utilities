using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class Int
    {
        /// <returns>Random value from -1 to 1</returns>
        public static int RandomNP => Random.Range( -1, 2 );

        /// <returns>Random value from 0 to 1</returns>
        public static int Random01 => Random.Range( 0, 2 );

        /// <returns>Random value from 0 to 100</returns>
        public static int RandomPercent => Random.Range( 0, 101 );

        /// <returns>Random value from 0 to 10</returns>
        public static int RandomFromTen => Random.Range( 0, 11 );

        /// <returns>Random value from 0 to 5</returns>
        public static int RandomFromFive => Random.Range( 0, 6 );
    }
}