using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class V3
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector3 RandomNP => new Vector3( Float.RandomNP, Float.RandomNP, Float.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector3 Random01 => new Vector3( Float.Random01, Float.Random01, Float.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector3 RandomPercent => new Vector3( Float.RandomPercent, Float.RandomPercent, Float.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector3 RandomFromTen => new Vector3( Float.RandomFromTen, Float.RandomFromTen, Float.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector3 RandomFromFive => new Vector3( Float.RandomFromFive, Float.RandomFromFive, Float.RandomFromFive );
    }
}