using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class Float
    {
        /// <returns>Random value from -1 to 1</returns>
        public static float RandomNP => Random.Range( -1f, 1f );

        /// <returns>Random value from 0 to 1</returns>
        public static float Random01 => Random.Range( 0f, 1f );

        /// <returns>Random value from 0 to 100</returns>
        public static float RandomPercent => Random.Range( 0f, 100f );

        /// <returns>Random value from 0 to 10</returns>
        public static float RandomFromTen => Random.Range( 0f, 10f );

        /// <returns>Random value from 0 to 5</returns>
        public static float RandomFromFive => Random.Range( 0f, 5f );
    }
}