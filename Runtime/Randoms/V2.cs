using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class V2
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector2 RandomNP => new Vector2( Float.RandomNP, Float.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector2 Random01 => new Vector2( Float.Random01, Float.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector2 RandomPercent => new Vector2( Float.RandomPercent, Float.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector2 RandomFromTen => new Vector2( Float.RandomFromTen, Float.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector2 RandomFromFive => new Vector2( Float.RandomFromFive, Float.RandomFromFive );
    }
}