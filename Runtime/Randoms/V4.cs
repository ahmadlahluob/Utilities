using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class V4
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector4 RandomNP => new Vector4( Float.RandomNP, Float.RandomNP, Float.RandomNP, Float.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector4 Random01 => new Vector4( Float.Random01, Float.Random01, Float.Random01, Float.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector4 RandomPercent => new Vector4( Float.RandomPercent, Float.RandomPercent, Float.RandomPercent, Float.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector4 RandomFromTen => new Vector4( Float.RandomFromTen, Float.RandomFromTen, Float.RandomFromTen, Float.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector4 RandomFromFive => new Vector4( Float.RandomFromFive, Float.RandomFromFive, Float.RandomFromFive, Float.RandomFromFive );
    }
}